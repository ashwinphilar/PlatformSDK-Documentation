namespace SecureMessagingApiClient
{
    partial class MessagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesForm));
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.lblRequest = new System.Windows.Forms.Label();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.gbMessages = new System.Windows.Forms.GroupBox();
            this.gvMessages = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkReceived = new System.Windows.Forms.DataGridViewButtonColumn();
            this.messageRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabMessage = new System.Windows.Forms.TabControl();
            this.tpMessage = new System.Windows.Forms.TabPage();
            this.messageControl = new SecureMessagingApiClient.Modules.MessageControl();
            this.tpAttachments = new System.Windows.Forms.TabPage();
            this.gvAttachments = new System.Windows.Forms.DataGridView();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fileSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentMimeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encodingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDispositions = new System.Windows.Forms.TabPage();
            this.gvDispositions = new System.Windows.Forms.DataGridView();
            this.recipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disposedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPostDisposition = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dispositionRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fdSave = new System.Windows.Forms.SaveFileDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvcFileName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbActions.SuspendLayout();
            this.gbMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageRowBindingSource)).BeginInit();
            this.tabMessage.SuspendLayout();
            this.tpMessage.SuspendLayout();
            this.tpAttachments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            this.tbDispositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDispositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositionRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.lblRequest);
            this.gbActions.Controls.Add(this.tbRequest);
            this.gbActions.Controls.Add(this.btnGet);
            this.gbActions.Location = new System.Drawing.Point(10, 2);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(677, 67);
            this.gbActions.TabIndex = 26;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Actions";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(108, 30);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(61, 17);
            this.lblRequest.TabIndex = 26;
            this.lblRequest.Text = "Request";
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(175, 27);
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(487, 22);
            this.tbRequest.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGet.Location = new System.Drawing.Point(12, 20);
            this.btnGet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(80, 34);
            this.btnGet.TabIndex = 25;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // gbMessages
            // 
            this.gbMessages.Controls.Add(this.gvMessages);
            this.gbMessages.Location = new System.Drawing.Point(10, 75);
            this.gbMessages.Name = "gbMessages";
            this.gbMessages.Size = new System.Drawing.Size(678, 133);
            this.gbMessages.TabIndex = 27;
            this.gbMessages.TabStop = false;
            this.gbMessages.Text = "Messages";
            // 
            // gvMessages
            // 
            this.gvMessages.AllowUserToAddRows = false;
            this.gvMessages.AllowUserToDeleteRows = false;
            this.gvMessages.AutoGenerateColumns = false;
            this.gvMessages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvMessages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.receivedDataGridViewTextBoxColumn1,
            this.MarkReceived});
            this.gvMessages.DataSource = this.messageRowBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMessages.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMessages.Location = new System.Drawing.Point(3, 18);
            this.gvMessages.MultiSelect = false;
            this.gvMessages.Name = "gvMessages";
            this.gvMessages.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMessages.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvMessages.RowTemplate.Height = 24;
            this.gvMessages.Size = new System.Drawing.Size(672, 112);
            this.gvMessages.TabIndex = 1;
            this.gvMessages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMessages_CellContentClick);
            this.gvMessages.SelectionChanged += new System.EventHandler(this.gvMessages_SelectedValueChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // receivedDataGridViewTextBoxColumn1
            // 
            this.receivedDataGridViewTextBoxColumn1.DataPropertyName = "Received";
            this.receivedDataGridViewTextBoxColumn1.HeaderText = "Received";
            this.receivedDataGridViewTextBoxColumn1.Name = "receivedDataGridViewTextBoxColumn1";
            this.receivedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MarkReceived
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MarkReceived.DefaultCellStyle = dataGridViewCellStyle2;
            this.MarkReceived.HeaderText = "Post Received";
            this.MarkReceived.Name = "MarkReceived";
            this.MarkReceived.ReadOnly = true;
            this.MarkReceived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MarkReceived.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MarkReceived.Text = "Post";
            this.MarkReceived.ToolTipText = "Mark Message as Received";
            this.MarkReceived.UseColumnTextForButtonValue = true;
            // 
            // messageRowBindingSource
            // 
            this.messageRowBindingSource.DataSource = typeof(SecureMessagingApiClient.MessageRow);
            // 
            // tabMessage
            // 
            this.tabMessage.Controls.Add(this.tpMessage);
            this.tabMessage.Controls.Add(this.tpAttachments);
            this.tabMessage.Controls.Add(this.tbDispositions);
            this.tabMessage.Location = new System.Drawing.Point(10, 214);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.SelectedIndex = 0;
            this.tabMessage.Size = new System.Drawing.Size(678, 472);
            this.tabMessage.TabIndex = 30;
            // 
            // tpMessage
            // 
            this.tpMessage.Controls.Add(this.messageControl);
            this.tpMessage.Location = new System.Drawing.Point(4, 25);
            this.tpMessage.Name = "tpMessage";
            this.tpMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tpMessage.Size = new System.Drawing.Size(670, 443);
            this.tpMessage.TabIndex = 0;
            this.tpMessage.Text = "Message";
            this.tpMessage.UseVisualStyleBackColor = true;
            // 
            // messageControl
            // 
            this.messageControl.Body = "";
            this.messageControl.CC = "";
            this.messageControl.From = "";
            this.messageControl.Location = new System.Drawing.Point(0, 0);
            this.messageControl.MessageId = "";
            this.messageControl.MessageIdEnabled = true;
            this.messageControl.Name = "messageControl";
            this.messageControl.Size = new System.Drawing.Size(673, 446);
            this.messageControl.Subject = "";
            this.messageControl.TabIndex = 31;
            this.messageControl.To = "";
            // 
            // tpAttachments
            // 
            this.tpAttachments.Controls.Add(this.gvAttachments);
            this.tpAttachments.Location = new System.Drawing.Point(4, 25);
            this.tpAttachments.Name = "tpAttachments";
            this.tpAttachments.Padding = new System.Windows.Forms.Padding(3);
            this.tpAttachments.Size = new System.Drawing.Size(670, 443);
            this.tpAttachments.TabIndex = 1;
            this.tpAttachments.Text = "Attachments";
            this.tpAttachments.UseVisualStyleBackColor = true;
            // 
            // gvAttachments
            // 
            this.gvAttachments.AllowUserToAddRows = false;
            this.gvAttachments.AllowUserToDeleteRows = false;
            this.gvAttachments.AutoGenerateColumns = false;
            this.gvAttachments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAttachments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAttachments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.Download,
            this.fileSizeDataGridViewTextBoxColumn,
            this.contentMimeTypeDataGridViewTextBoxColumn,
            this.encodingDataGridViewTextBoxColumn});
            this.gvAttachments.DataSource = this.attachmentBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAttachments.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAttachments.Location = new System.Drawing.Point(3, 3);
            this.gvAttachments.MultiSelect = false;
            this.gvAttachments.Name = "gvAttachments";
            this.gvAttachments.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAttachments.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvAttachments.RowTemplate.Height = 24;
            this.gvAttachments.Size = new System.Drawing.Size(664, 437);
            this.gvAttachments.TabIndex = 0;
            this.gvAttachments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAttachments_CellContentClick);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Download
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Download.DefaultCellStyle = dataGridViewCellStyle6;
            this.Download.HeaderText = "Download";
            this.Download.Name = "Download";
            this.Download.ReadOnly = true;
            this.Download.Text = "Get";
            this.Download.ToolTipText = "Download Attachment";
            this.Download.UseColumnTextForButtonValue = true;
            // 
            // fileSizeDataGridViewTextBoxColumn
            // 
            this.fileSizeDataGridViewTextBoxColumn.DataPropertyName = "FileSize";
            this.fileSizeDataGridViewTextBoxColumn.HeaderText = "FileSize";
            this.fileSizeDataGridViewTextBoxColumn.Name = "fileSizeDataGridViewTextBoxColumn";
            this.fileSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentMimeTypeDataGridViewTextBoxColumn
            // 
            this.contentMimeTypeDataGridViewTextBoxColumn.DataPropertyName = "ContentMimeType";
            this.contentMimeTypeDataGridViewTextBoxColumn.HeaderText = "ContentMimeType";
            this.contentMimeTypeDataGridViewTextBoxColumn.Name = "contentMimeTypeDataGridViewTextBoxColumn";
            this.contentMimeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encodingDataGridViewTextBoxColumn
            // 
            this.encodingDataGridViewTextBoxColumn.DataPropertyName = "Encoding";
            this.encodingDataGridViewTextBoxColumn.HeaderText = "Encoding";
            this.encodingDataGridViewTextBoxColumn.Name = "encodingDataGridViewTextBoxColumn";
            this.encodingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attachmentBindingSource
            // 
            this.attachmentBindingSource.DataSource = typeof(SecureMessagingApiClient.AttachmentServiceReference.attachment);
            // 
            // tbDispositions
            // 
            this.tbDispositions.Controls.Add(this.gvDispositions);
            this.tbDispositions.Location = new System.Drawing.Point(4, 25);
            this.tbDispositions.Name = "tbDispositions";
            this.tbDispositions.Padding = new System.Windows.Forms.Padding(3);
            this.tbDispositions.Size = new System.Drawing.Size(670, 443);
            this.tbDispositions.TabIndex = 2;
            this.tbDispositions.Text = "Dispositions";
            this.tbDispositions.UseVisualStyleBackColor = true;
            // 
            // gvDispositions
            // 
            this.gvDispositions.AllowUserToAddRows = false;
            this.gvDispositions.AllowUserToDeleteRows = false;
            this.gvDispositions.AutoGenerateColumns = false;
            this.gvDispositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDispositions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDispositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvDispositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDispositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipientDataGridViewTextBoxColumn,
            this.disposedDataGridViewTextBoxColumn,
            this.btnPostDisposition});
            this.gvDispositions.DataSource = this.dispositionRowBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDispositions.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvDispositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDispositions.Location = new System.Drawing.Point(3, 3);
            this.gvDispositions.MultiSelect = false;
            this.gvDispositions.Name = "gvDispositions";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDispositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvDispositions.RowTemplate.Height = 24;
            this.gvDispositions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDispositions.Size = new System.Drawing.Size(664, 437);
            this.gvDispositions.TabIndex = 1;
            this.gvDispositions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDispositions_CellContentClick);
            // 
            // recipientDataGridViewTextBoxColumn
            // 
            this.recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
            this.recipientDataGridViewTextBoxColumn.HeaderText = "Recipient";
            this.recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
            // 
            // disposedDataGridViewTextBoxColumn
            // 
            this.disposedDataGridViewTextBoxColumn.DataPropertyName = "Disposed";
            this.disposedDataGridViewTextBoxColumn.HeaderText = "Disposed";
            this.disposedDataGridViewTextBoxColumn.Name = "disposedDataGridViewTextBoxColumn";
            // 
            // btnPostDisposition
            // 
            this.btnPostDisposition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.btnPostDisposition.DefaultCellStyle = dataGridViewCellStyle10;
            this.btnPostDisposition.HeaderText = "Post Disposition";
            this.btnPostDisposition.Name = "btnPostDisposition";
            this.btnPostDisposition.Text = "Post";
            this.btnPostDisposition.ToolTipText = "Post Disposition";
            this.btnPostDisposition.UseColumnTextForButtonValue = true;
            this.btnPostDisposition.Width = 104;
            // 
            // dispositionRowBindingSource
            // 
            this.dispositionRowBindingSource.DataSource = typeof(SecureMessagingApiClient.DispositionRow);
            // 
            // fdSave
            // 
            this.fdSave.Title = "Save Attachment";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 44;
            // 
            // receivedDataGridViewTextBoxColumn
            // 
            this.receivedDataGridViewTextBoxColumn.DataPropertyName = "Received";
            this.receivedDataGridViewTextBoxColumn.HeaderText = "Received";
            this.receivedDataGridViewTextBoxColumn.Name = "receivedDataGridViewTextBoxColumn";
            this.receivedDataGridViewTextBoxColumn.ReadOnly = true;
            this.receivedDataGridViewTextBoxColumn.Width = 92;
            // 
            // gvcFileName
            // 
            this.gvcFileName.DataPropertyName = "FileName";
            this.gvcFileName.HeaderText = "File Name";
            this.gvcFileName.Name = "gvcFileName";
            this.gvcFileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvcFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gvcFileName.Width = 96;
            // 
            // MessagesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(696, 690);
            this.Controls.Add(this.tabMessage);
            this.Controls.Add(this.gbMessages);
            this.Controls.Add(this.gbActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessagesForm";
            this.Text = "Messages Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.gbMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageRowBindingSource)).EndInit();
            this.tabMessage.ResumeLayout(false);
            this.tpMessage.ResumeLayout(false);
            this.tpAttachments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            this.tbDispositions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDispositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispositionRowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.GroupBox gbMessages;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.TabControl tabMessage;
        private System.Windows.Forms.TabPage tpMessage;
        private Modules.MessageControl messageControl;
        private System.Windows.Forms.TabPage tpAttachments;
        private System.Windows.Forms.DataGridView gvAttachments;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private System.Windows.Forms.SaveFileDialog fdSave;
        private System.Windows.Forms.DataGridView gvMessages;
        private System.Windows.Forms.BindingSource messageRowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn MarkReceived;
        private System.Windows.Forms.DataGridViewLinkColumn gvcFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentMimeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encodingDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tbDispositions;
        private System.Windows.Forms.DataGridView gvDispositions;
        private System.Windows.Forms.BindingSource dispositionRowBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn disposedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disposedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnPostDisposition;
        private System.Windows.Forms.Label lblRequest;
    }
}