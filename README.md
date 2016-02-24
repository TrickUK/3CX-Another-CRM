# 3CX Another CRM
A demonstration of how to integrate with 3CXPhone API from a custom CRM platform.

This method uses WCF to communication between 3CXPhone and CRM processes in an asynchronous fashion.

It covers basic call handling, which is easily extensible to database lookups etc in your own application.

![Screenshot](https://github.com/TrickUK/3CX-Another-CRM/raw/master/screenshot.png "Screenshot")

## Instructions

The solution should build out the box and copy the Common and Integration assemblies to the 3CXPhone folder in ProgramData.
The only manual intervention required will be to edit the **3CXWin8Phone.user.config** file's CRMPlugin key, so the application loads the plugin:

```xml
<add key="CRMPlugin" value="CallTriggerCmdPlugin,AnotherCRM.Integration"/>
```