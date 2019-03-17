# Azure Functions Playground
- [Azure Functions Playground](#azure-functions-playground)
  - [Intro](#intro)
  - [Required & Optional Software / SDK's etc](#required--optional-software--sdks-etc)
  - [To run the app via a command line](#to-run-the-app-via-a-command-line)

## Intro

This is me playing around with Azure Functions, I'm going to be adding bits and pieces to this repository as I learn new things about Azure Functions.

## Required & Optional Software / SDK's etc

- Visual Studio (opt)
- Visual Studio Code
  - [REST Client (extension)](https://marketplace.visualstudio.com/items?itemName=humao.rest-client)
  - [Azure Tools (extension)](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-node-azure-pack)
  - [Azure Functions (extensions)](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurefunctions)
- DOTNET CORE SDK 2.2
- DOTNET CORE Runtime 2.2

## To run the app via a command line

If you want to run this on a Mac, or via command line, you need to navigate to a folder containing a `csproj` file, and run `func host start --build`, you should then see an output similar to 

```bash
Available options: dotnet, node, python

                  %%%%%%
                 %%%%%%
            @   %%%%%%    @
          @@   %%%%%%      @@
       @@@    %%%%%%%%%%%    @@@
     @@      %%%%%%%%%%        @@
       @@         %%%%       @@
         @@      %%%       @@
           @@    %%      @@
                %%
                %

Azure Functions Core Tools (2.4.419 Commit hash: c9c1724d002bd90b2e6b41393915ea3a26bcf0ce)
Function Runtime Version: 2.0.12332.0
[16/03/2019 01:32:15] Starting Rpc Initialization Service.
[16/03/2019 01:32:15] Initializing RpcServer.).
...
Removed for brevity
...
[16/03/2019 01:32:15] Host initialized (95ms)
[16/03/2019 01:32:15] Host started (107ms)
[16/03/2019 01:32:15] Job host started
Hosting environment: Production
Content root path: /Users/chrisjones/Projects/azure-functions/FunctionApp1
Now listening on: http://0.0.0.0:7071
Application started. Press Ctrl+C to shut down.
[
```