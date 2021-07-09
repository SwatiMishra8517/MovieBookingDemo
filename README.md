# MovieBookingDemo

Movie Booking app codebase project and documents repository

Documents

- Wireframe
- Database Schema

Project

- Models
- Web Pages
- Controllers

GitHub Cheatsheet - [Cheat sheet](Documents/gitsheet.pdf)

# Setting Up Github

## 1. Installing Git-Bash

Go to: [Git-Bash](https://git-scm.com/downloads)
and dowload the latest git version and Install it

## 2. Adding SSH Key to your Git-Bash

In Git-Bash

### Step 1

```shell
ssh-keygen -t ed25519 -C "your@email.com"
```

your@email.com - Enter your Email address

### Step 2

```shell
clip < ~/.ssh/[key-id].pub
```

the folllowing command copies your key to clipboard

In Browser  
```Github Account -> Settings -> SSH & GPG Keys => New SSH Key```<br>
Fill the Fields as following

  >**Title**: Any name you want  
  >**Key**: Paste after executing command in "Step 2"

## 3. Config username and email

In Git-Bash

```shell
git config --global user.email "your@email.com"
git config --global user.name "FName LName"
```

Enter your Email id and Username

## 4. Fork Repo

In Browser  
Go to: [Online Movie Booking Repo](https://github.com/Hypernik/MovieBookingDemo)  
and Fork it to your account [Fork button Located on TOP RIght Conrner]

## 5. Clone Repo

In Browser  
In your GitHub Account  
Click Code and copy the ssh - "git@github.com:[Username]/MovieBookingDemo.git"

In Git-Bash  
cd to directory you want the project to be

```shell
git clone git@github.com:[Username]/MovieBookingDemo.git
```

Change "Username" to your username  
**By this time you would have the project downloaded in your system**

# Github Commands to use

## Status

```shell
git status
```

Tells the changes that need to be added and more

## Add

```shell
git add *
git add [filename]
```

Used to add files to the commit  
**"\*"** is used for adding all  
**"[filename]"** is used for adding specific file

## Commit

```shell
git commit -m "[Commit Message]" -m "[Commit Description]"
```

Used for adding commit to the local repo  
**"[Commit Message]"** commit messages are mandatory  
**"[Commit Description]"** commit description are optional

## Push

```shell
git push origin main
```

Pushes the commit to your GitHub Repo
