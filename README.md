# Crowdstrike_Falcon_Orchestrator-CSEC475-2171-Adler-Martin-Myers

Forensics Modules for Crowdstrike's Falcon Orchestrator.
The modules we plan to implement add advanced forensics capability to the tool

# Documentation
This forensics module enables Orchestrator users to generate hashes of files on any computer under Orchestrator and upload the hashes to virus total.
The hashing potion of the module outputs both MD5 and SHA512 hashes. After the hash is generated the user can automatically submit the hash to Virus Total and recieve a detailed report about the results.

## Instructions

### 1 Setup Falcon Orchestrator
Install this [Falcon Orchestrator](https://github.com/CrowdStrike/falcon-orchestrator) module by using the instructions that Crowdstrike provides.
Upon a successful pull request our tool will be integrated into Falcon Orchestrator by default.

### 2 Navigation
The Forensics module is added to the user interface which can simply be clicked to open the hashing interface.
![alt text](https://raw.githubusercontent.com/micahjmartin/Crowdstrike_Falcon_Orchestrator-CSEC475-2171-Adler-Martin-Myers/master/img1.PNG)

### 3 File Hashing
To hash a file users can enter the name of a Falcon Orchestrator enabled computer into the Computer textbox.  The direct file path to the target file on that machine must be entered into the File Path textbox.

### 4 Results
The Forensic Module returns both an MD5 and SHA512 hash with can be submitted to Virus Total using the "Submit to Virus Total" button.

# Authors
[Micah Martin](https://github.com/micahjmartin)
[Brandon Adler](https://github.com/BCAdler)
[Jon Myers](https://github.com/JonLMyers)

# License

This project is primary licensed under Affero GPLv3 license.
Our modules will be licensed as this as well 
