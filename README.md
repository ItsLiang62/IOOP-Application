# IOOP-Application
A place to get the latest version of the -- IOOP Assignment -- that we have done so far.


Dictionary: "local" means on your computer, "remote" means on the GitHub website


Develop the application on the local feature branch corresponding to your role.
The "main" branch will store the APPROVED COMMITS ONLY.
Create a PULL REQUEST from your remote feature branch if you want your commits to be merged into remote "main", meaning requesting your commits to be pulled/merged into remote "main".
First, push your localfeature branch commits to the corresponding remote feature branch, then create the pull request in here, GitHub website, from the branch.
I will review it. If it's approved, I will pull/merge those commits into the remote "main" branch here.

After I have approved, I will delete the remote feature branch that corresponds to your role (where the pull request come from) and create a new one with the same name, so that your remote feature branch is on track with "main" again. But you need to recreate your local feature branch that tracks your new remote feature branch also, to continue developing the application.

So, DO NOT MERGE YOUR LOCAL FEATURE BRANCH INTO LOCAL "MAIN" BRANCH because it will make your local "main" branch to be ahead of remote "main" branch. Which in this case you must use these commands to make your local "main" branch on track with the remote "main" branch again:

git checkout main
git reset --hard origin/main

So in conclusion, your local "main" branch job is to only pull the commits from the remote "main" branch, no direct pushing. Just a reminder that your local "main" branch represents a real copy of our IOOP Application on your computer ya, which you should know already.
