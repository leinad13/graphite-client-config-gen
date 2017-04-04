# graphite-client-config-gen
App to list and select performance counters from local or remote windows machine and create a config file for [graphite-client](https://github.com/peschuster/graphite-client)

[![Build status](https://ci.appveyor.com/api/projects/status/v3yxa5ycmahrdi71/branch/master?svg=true)](https://ci.appveyor.com/project/leinad13/graphite-client-config-gen/branch/master)

# Description
This application will list the available performance counters on a local or remote windows machine and display them in a tree for selection. Once performance counters have been selected it can export an xml file, for use with [PerfCounterMonitor.exe](https://github.com/peschuster/graphite-client/wiki/System-Metrics).
Currently only supports graphite output, but wouldn't be difficult to add support for StatsD as well.

## Features
* Easy selection of system performance metrics
* Custom Key Template - gives the ability to control the key (name used by graphite for the metric)
* TODO - Metric templates to allow easy configuration of same metrics accross groups of servers.
* TODO - Connect to Group - enter list of machines, connect and list metrics only available on all servers

## This application is functional, but may be unstable
