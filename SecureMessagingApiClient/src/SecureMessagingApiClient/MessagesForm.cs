using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using SecureMessagingApiClient.Helpers;
using SecureMessagingApiClient.MessagesServiceReference;
using addresstype = SecureMessagingApiClient.MessageDisposedServiceReference.addresstype;
using disposedAddress = SecureMessagingApiClient.MessageDisposedServiceReference.address;
using dispositionType = SecureMessagingApiClient.MessageDisposedServiceReference.dispositionType;
using attachment = SecureMessagingApiClient.AttachmentServiceReference.attachment;

namespace SecureMessagingApiClient
{
    public partial class MessagesForm : Form
    {
        #region Fields

        /// <summary>
        /// MessageListResponse returned from Messages Service
        /// </summary>
        private messagelistresponse _response;

        /// <summary>
        /// Current User Selected Message
        /// </summary>
        private messagelistitem _selectedMessage;

        /// <summary>
        /// To Keep Track of Received Status
        /// </summary>
        private List<MessageRow> _messageRows;

        /// <summary>
        /// To Keep Track of Disposed Status
        /// </summary>
        private List<DispositionRow> _dispositionRows;

        #endregion

        #region Constructors

        public MessagesForm()
        {
            InitializeComponent();

            //Add dispositionType Enum column to Disposition GridView
            var column = new DataGridViewComboBoxColumn
            {
                Name = "Disposition Types",
                DataSource = Enum.GetNames(typeof(dispositionType)).OrderBy(x => x.ToString()).ToList(),
                ReadOnly = false,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
            };
            gvDispositions.Columns.Add(column);
        }

        #endregion

        #region Service Calls

        /// <summary>
        /// Get Messages
        /// </summary>
        private void getMessages()
        {
            messageControl.ClearForm();
            Cursor = Cursors.WaitCursor;
            try
            {
                // Call Get Service Method
                _response = MessagesHelper.Get(tbRequest.Text, getCertificate());

                //Update UI with Results
                _messageRows = _response.Messages.Select(m => new MessageRow { Id = m.Id, Received = bool.FalseString }).ToList();
                gvMessages.DataSource = _messageRows;
            }
            catch (Exception exception)
            {
                displayError(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        
        /// <summary>
        /// Download Attachment
        /// </summary>
        private void getAttachment()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //Get Inputs From User Selections
                var id = _selectedMessage.Attachments.Single(a => a.FileName == gvAttachments.CurrentRow.Cells[0].Value.ToString()).Id;

                //Call Get Service Method
                var attachment = AttachmentHelper.Get(_selectedMessage.Id, id, getCertificate());

                //Save Attachment to Disk
                saveAttachment(attachment);
            }
            catch (Exception exception)
            {
                displayError(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Mark Selected Message as Received
        /// </summary>
        private void postReceived()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                //Call Post Service Method
                var success = MessageReceivedHelper.Post(_selectedMessage.Id, getCertificate());

                //Update UI with Results
                _messageRows.Single(m => m.Id == _selectedMessage.Id).Received = success.ToString();
                gvMessages.DataSource = _messageRows;
                gvMessages.Refresh();
            }
            catch (Exception exception)
            {
                displayError(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Mark Selected Recipient as Disposed
        /// </summary>
        private void postDisposed()
        {
            if (gvDispositions.CurrentRow.Cells[3].Value == null)
            {
                MessageBox.Show("Please select a Disposition Type.", "Required");
                return;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                //Get Selected Recipient of Disposition
                var recipient = gvDispositions.CurrentRow.Cells[0].Value.ToString();
                //Create Address Type using Recipient
                var address = new disposedAddress { Value = recipient, Type = addresstype.Direct };
                //Parse Disposition from Selected Disposition in DropDownList
                var disposition = (dispositionType)Enum.Parse(typeof(dispositionType), gvDispositions.CurrentRow.Cells[3].Value.ToString());

                //Call Post Service Method
                var success = MessageDisposedHelper.Post(_selectedMessage.Id, address, disposition, getCertificate());

                //Update UI with Results
                _dispositionRows.Single(d => d.Recipient == recipient).Disposed = success.ToString();
                gvDispositions.DataSource = _dispositionRows;
                gvDispositions.Refresh();
            }
            catch (Exception exception)
            {
                displayError(exception);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// Get Messages 
        /// </summary>
        private void btnGet_Click(object sender, EventArgs e)
        {
            getMessages();
        }

        /// <summary>
        /// Update Control when Selected Guid changes.
        /// </summary>
        private void gvMessages_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_response == null) return;

            _selectedMessage = _response.Messages.SingleOrDefault(m => m.Id.ToString() == gvMessages.CurrentRow.Cells[0].Value.ToString());

            if (_selectedMessage == null) return;

            messageControl.From = _selectedMessage.From.Value;
            messageControl.To = string.Join("; ", _selectedMessage.To.Select(m => m.Value));
            messageControl.CC = string.Join("; ", _selectedMessage.CC.Select(m => m.Value));
            messageControl.Subject = _selectedMessage.Subject;
            messageControl.Body = _selectedMessage.Body;
            messageControl.MessageId = _selectedMessage.Id.ToString();

            //Bind Attachments Grid View
            gvAttachments.DataSource = _selectedMessage.Attachments;

            //Bind Dispositions Grid View
            bindDispositionRows();
        }
        
        /// <summary>
        /// Save attachment to Disk
        /// </summary>
        private void saveAttachment(attachment attachment)
        {
            fdSave.FileName = attachment.FileName;
            var result = fdSave.ShowDialog();

            if ((fdSave.FileName == string.Empty) || (result != DialogResult.OK)) return;

            File.WriteAllBytes(fdSave.FileName, attachment.Content);
        }

        /// <summary>
        /// Perform Click Actions Based on Column Clicked
        /// </summary>
        private void gvAttachments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    getAttachment();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Perform Click Actions Based on Column Clicked
        /// </summary>
        private void gvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    postReceived();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Perform Click Actions Based on Column Clicked
        /// </summary>
        private void gvDispositions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 2:
                    postDisposed();
                    break;
                default:
                    break;
            }
        }
        
        /// <summary>
        /// Bind Disposition Rows to Grid View
        /// </summary>
        private void bindDispositionRows()
        {
            _dispositionRows = _selectedMessage.To.Union(_selectedMessage.CC)
                                                  .Select(d => new DispositionRow
                                                                   {
                                                                       Recipient = d.Value,
                                                                       Disposed = bool.FalseString
                                                                   }).ToList();
            gvDispositions.DataSource = _dispositionRows;
        }

        /// <summary>
        /// Retrieve Certificate from Parent Form
        /// </summary>
        /// <returns></returns>
        private X509Certificate2 getCertificate()
        {
            return SecureMessagingHelper.GetCertificate((MainForm)MdiParent);
        }

        /// <summary>
        /// Clear Grids if an error occurrs and Show Error Form.
        /// </summary>
        private void displayError(Exception exception)
        {
            gvMessages.DataSource = null;
            gvAttachments.DataSource = null;
            gvDispositions.DataSource = null;
            messageControl.ClearForm();
            SecureMessagingHelper.ShowErrorForm(exception);
        }

        #endregion
    }
}
