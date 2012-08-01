# A Day in the Life with Git

To give developers some insight into the daily life working with Git, the following describes a _cadence_ of using Git. Rather than start at repository creation, this details a regular day in the life.

> It should be noted that this cadence is designed for a team working with a single, shared GitHub repository -- contained within an organization on the GitHub server. All team members have commit access to the repository.

## Today

### Good Morning, Dave.

Once ready to start work, let's jump into the repository. When we left yesterday, we were not working on any particular feature, leaving us with a clean working directory. For this project, we are working in the _develop_ branch and want to pull any changes that have been committed to the repository since our last pull.

    $ git fetch origin
    $ git checkout develop
    $ git rebase origin/develop

First, assume we are at the root of our project working directory (in this case `D:\Project`). The first command, `git fetch origin`, fetches any commits from the remote repository named _origin_. Origin is the name typically the primary remote repository, normally GitHub. The next command, `git checkout develop`, ensures that the working directory is on the _develop_ branch. The third command, `git rebase origin/develop`, requires some additional explanation.

#### Distributed Version Control?

With centralized version control systems, such as Subversion, a central server is responsible for coordinating commits sequentially to a single repository. The central server manages commits and conflicts, preventing commits that would compromise the history of the repository. With Git, everything is distributed and commits are performed at the local repository. Once changes are committed, those commits can be exchanged with _clones_ of the repository using a series of push and pull (or more explicitly fetch) commands.

At the end of the previous day, the HEAD of our develop branch pointed to a specific commit in the repository. This may or may not be the same commit that the GitHub server clone of the repository is pointing at on that same branch. In order to make sure that our local develop branch is _based_ off the same commits as what is already on the GitHub server, the _rebase_ command is used.

By _rebasing_ our local develop branch to the origin/develop branch, we are synchronizing our local develop branch so that it has the same history as the GitHub server. At the same time, any local commits on the develop branch are _replayed_ at the newly synchronized HEAD of our local develop branch. This results in a linear, clean history of commits.

At this point, our local develop branch is now up-to-date with what has been pushed to the GitHub server by other members of the development team.

### Time to Get to Work

Now, we've picked up a story to work for today. After grabbing our pair, we sit down and start to work on the feature. First, we're going to create a branch for the changes to keep them isolated.

    $ git checkout -b feature-123

That's it, we've created a local branch named _feature-123_ from our freshly synchronized develop branch, in less time than it took you to hit the _Enter_ key. The `checkout` command is used to checkout a branch, in this case we added the `-b` option to create the new branch.

At this point, we make changes to some files, add a few new ones, and perhaps remove some previous files that are no longer valid. Regardless of what changes were made, we need to commit those changes to the repository as our testing is done and it's working perfectly.

    $ git add --all .
    $ git commit -m "Completes feature mentioned in issue #123"

The first command, `git add --all .`, adds all changes to the _index_. The index is where changes are staged before being committed to the repository (we should probably discuss the Three Trees of Git sometime).

> If additional changes were made after the `add` command was executed, those changes are not added to the index and exist in the working directory only. If those changes are also to be included in the commit, the add command should be repeated to add the newly changed files to the index.

The `--all` command selected all file changes (tracked as adds/changes/deletes). The `.` simply signifies the directory to start processing, in this case the current directory (assume we were in the root project directory). 

> In an established repository, this is the best way to capture all changes. Typically this involves a properly configured `.gitignore` file in the root of the repository to avoid adding user-specific IDE files, temporary files, build output files, logs, etc. from the repository.

The second command, `git commit -m "..."`, performs the commit to the repository. And that's it, the changes are committed.


### Merging Changes

Once the changes are committed to our feature branch, those changes need to be merged into the develop branch so they can be pushed to the remote repository. However, merge is not what we want to do here as it creates a nasty history that's difficult to manage. In this case, we'll show how to do it the proper way to ensure a clean _merge_.

    $ git checkout develop
    $ git merge --ff-only feature-123

The first command, as above, changes our working directory to point to the develop branch. At this point, the local changes from our working directory are gone and only exist in the feature-123 branch -- which we currently do not have checked out.

The second command attempts to merge the feature branch into develop, but only if the merge can be done as a _fast-forward_ merge. If there are commits to the develop branch that occurred after the feature-123 branch was created, we will need to rebase our feature branch from develop. If this were the case, additional commands may be needed.

    $ git checkout feature-123
    $ git rebase develop
    $ git checkout develop
    $ git merge -ff-only feature-123

These commands are only needed if there were changes to develop that weren't in feature-123 yet. Rebasing will be covered separately as it can be interesting if the changes are widely scattered.

### Pushing to GitHub

Now that our local develop branch includes the commits in the feature-123 branch, it is time to push those changes to the GitHub server. 

    $ git push origin develop

The `push` command sends commits on our local develop branch to the develop branch on the remote named origin (which in this case, is our GitHub server). If commits have been pushed to the remote server since we last fetched and rebased our local develop branch, the push will be rejected with an `unable to fast-forward` error. If this happens, the _good morning_ and _merging changes_ dance needs to happen again to rebase and reapply the commits in order.


## Wrapping Up

That's it, that's a day in the life usage of Git for a developer working on a team using Git. The highlights have been covered, but there are additional use cases that may warrant the use of additional Git commands. Git is extremely powerful, and with power -- naturally -- comes great responsibility.
