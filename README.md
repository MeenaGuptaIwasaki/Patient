Patient
=======
###Contributing

* Create a new feature branch
```
git checkout -b branchname
```
or switch to an existing branch with
```
git checkout branchname
```
* After making changes, save your changes to your local
file system, and add them to the staging area. If you created
a file in Patient/Scenes called AwesomeScene.goat
```
git add Patient/Scenes/AwesomeScene.goat
```
or to add every change, use
```
git add .
```

* now commit the new change with a useful message
```
git commit -m "Adds a new scene called AwesomeScene"
```

* go back to your master branch with
```
git checkout master
```

* Merge your changes to your master branch
```
git merge branchname
```

* push your changes to your forked repository
```
git push
```

* Submit a pull request.
