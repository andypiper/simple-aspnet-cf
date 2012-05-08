Simple ASP.NET sample
================

A trivial example of an ASP.NET application in C# for deployment to a [Cloud Foundry](http://cloudfoundry.org) instance with .NET support (e.g. Uhuru).

## Overview

This example was built using [MonoDevelop](http://monodevelop.com) on OS X, and can be deployed to [Uhuru](http://uhurusoftware.com)'s cloud using the vmcu Ruby gem. It requires a Cloud Foundry instance that supports a .NET runtime.

## Deployment

First, fork the project. Then run:

    git clone git@github.com:<your_name>/simple-aspnet-cf.git simpleasp
    cd simpleasp/asp
    vi manifest.yml

Edit the application name in the manifest file to be a unique value (an appname must be a unique name across all applications running on Cloud Foundry), and save the file.

Ensure that the vmcu Ruby gem is installed.

    gem install vmcu

    vmcu target http://api.uhurucloud.net
    vmcu login
    vmcu push

Visit `http://appname.uhurucloud.net` in a browser to see the application.

## Observations

There are a few things to note in terms of coding and deployment requirements.

* the MonoDevelop wizard for creating ASP.NET applications adds customErrors to web.config - set customErrors mode="Off" for Uhuru unless you are adding your own.
* Uhuru is a .NET runtime, not Mono - so there may be some differences in functionality.
* there is no console output on Cloud Foundry.
* Uhuru stores VCAP_* variables in the web.config after deployment so they can be accessed via `ConfigurationManager.AppSettings`
* this app currently does not support multiple instances as there is no sticky session configuration in order to remain  simple.