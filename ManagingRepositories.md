# Leveraging GitHub for the development of the Platform SDK

There are two account types on GitHub, user accounts and organization accounts. Users are individual users, whereas organizations are standalone accounts to which users can "belong" - through the use of teams.

To manage the repositories for the Platform SDK, this PlatformSDK organization has been created. The primary repositories for the Platform SDK related projects will be hosted by this organization. These will be considered the official release sources for any assemblies, packages, documentation, and other artifacts created.


# Managing Repositories using Git

The following practices have been across a number of Git repositories and represent (in my opinion -CP) the best practices for using Git in the enterprise. They are certainly open to discussion, but the practices below have been used within RelayHealth and across many other organizations including several open source projects with great success.


## Branching in Repositories

Branching is one of the most powerful features of Git, allowing users to create local branches without any connection to a remote Git repository. The ease and speed of branching enables developers to quickly shift context when working on different features within a repository.

### master

By convention, _master_ is the default branch when using Git (similar to trunk in Subversion). It is also by convention that _master_ is typically a golden branch which should build and run at all times. This typically scales well for SAAS applications which only manage a single version in production at any given time.

### develop

For a project with a single team working from a single backlog, _develop_ is used as the current _working development branch_. Working is key, since it is expected that broken code is not checked into the _develop_ branch intentionally. Stories and/or features are often developed using a feature branch, and then integrated into the _develop_ branch once they are completed.

### feature-1234

Since _develop_ is really meant for final integration of completed features, a feature branch is used when developing a new feature, changing existing behavior, or any other changes to the repository. In most cases, it is best to name the branch with the story or issue number being worked on to allow other developers on the team to stay in sync with what's in the branch. Of course, this only applies if the branch is actually pushed to a remote repository -- if the branch is created locally, other developers won't see it.

### issue-123

Same as above, but working an issue or defect, again just for semantic value of the branch name.

### release-2.1.3

A release branch may be created when previously tagged (see below) releases require changes (due to defects, for example). In this case, a branch is created and becomes the new "master" branch for that release. As fixes are developed, local or remote branches can be created to manage and test those fixes. If a large number of changes are required, it may become necessary to create a matching _develop-2.1.3_ branch as well.


## Tagging Versions

To keep track of points in time within the repository when versions are released, tags are used. It is highly recommended that the build procedure for the project within the repository uses an incrementing version system so that every build gets a unique version number. When versions are released, the repository should be tagged.

> _Semantic Versioning (semver) is a highly popular method of managing SDK/API versions. There are rules that dictate what type of changes warrant which level of version increment (major, minor, or patch). These rules are meant to guide consumers of the SDK/API in how difficult a new version will be to integrate into their system. For example, upgrading from version 1.0.1 to version 1.0.2 should be completely painful and not introduce any regressions or require any coding changes on the part of the SDK/API consumer. On the other hand, an upgrade to version 2.0.0 would signify that code changes or recompilation may be required._

Both local and remote tags can be created, but version tags should be pushed to the server so they are centrally tracked.

