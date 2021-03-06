# SpeechService

A little PoC to unlock the system speech synthesis via a Web API.

## Command-Line Reference

  service.exe [verb] [-option:value] [-switch]

    run                 Runs the service from the command line (default)
    help, --help        Displays help

    install             Installs the service

      --autostart       The service should start automatically (default)
      --disabled        The service should be set to disabled
      --manual          The service should be started manually
      --delayed         The service should start automatically (delayed)
      -instance         An instance name if registering the service
                        multiple times
      -username         The username to run the service
      -password         The password for the specified username
      --localsystem     Run the service with the local system account
      --localservice    Run the service with the local service account
      --networkservice  Run the service with the network service permission
      --interactive     The service will prompt the user at installation for
                        the service credentials
      start             Start the service after it has been installed
      --sudo            Prompts for UAC if running on Vista/W7/2008

      -servicename      The name that the service should use when
                        installing
      -description      The service description the service should use when
                        installing
      -displayname      The display name the the service should use when
                        installing

    start               Starts the service if it is not already running

    stop                Stops the service if it is running

    uninstall           Uninstalls the service

      -instance         An instance name if registering the service
                        multiple times
      --sudo            Prompts for UAC if running on Vista/W7/2008

Examples:

    service install
        Installs the service into the service control manager

    service install -username:joe -password:bob --autostart
        Installs the service using the specified username/password and
        configures the service to start automatically at machine startup

    service uninstall
        Uninstalls the service

    service install -instance:001
        Installs the service, appending the instance name to the service name
        so that the service can be installed multiple times. You may need to
        tweak the log4net.config to make this play nicely with the log files.


## Usage

![Usage!](/assets/ApiCall.png "Post")
