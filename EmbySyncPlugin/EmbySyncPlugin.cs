using EmbySyncPlugin.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Session;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Serialization;
using System;
using System.Threading;

namespace EmbySyncPlugin
{
    public class EmbySyncPlugin : BasePlugin<PluginConfiguration>
    {

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static EmbySyncPlugin Instance { get; private set; }

        private ISessionManager sessionManager;
        private ILogger logger;

        public static bool testStop = false;


        public EmbySyncPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer, ISessionManager sessionManager, ILogger logger) : base(applicationPaths, xmlSerializer)
        { 
            Instance = this;
            this.sessionManager = sessionManager;
            this.logger = logger;

            sessionManager.PlaybackStart += SessionManager_PlaybackStart; ;
            sessionManager.PlaybackProgress += SessionManager_PlaybackProgress;
            sessionManager.PlaybackStopped += SessionManager_PlaybackStopped;
            sessionManager.SessionActivity += SessionManager_SessionActivity;
            sessionManager.SessionStarted += SessionManager_SessionStarted;
            
        }

        private void SessionManager_SessionStarted(object sender, SessionEventArgs e)
        {
            var q = 1;
        }

        private void SessionManager_SessionActivity(object sender, SessionEventArgs e)
        {
            var q = 1;

        }

        private void SessionManager_PlaybackStopped(object sender, MediaBrowser.Controller.Library.PlaybackStopEventArgs e)
        {
            var q = 1;
        }

        private void SessionManager_PlaybackProgress(object sender, MediaBrowser.Controller.Library.PlaybackProgressEventArgs e)
        {
            var q = 1;
            if (testStop)
            {
                try
                {
                    CancellationToken token = new CancellationToken();
                    sessionManager.SendPlaystateCommand(e.Session.Id, e.Session.Id, new MediaBrowser.Model.Session.PlaystateRequest()
                    {
                        Command = MediaBrowser.Model.Session.PlaystateCommand.Stop,
                        ControllingUserId = e.Session.UserId
                    },
                      token
                     );
                }
                catch(Exception ex)
                {
                    // Handle exception if needed
                    var q1 = 1;
                    logger.Log(LogSeverity.Error,  "Error stopping playback in EmbySyncPlugin" ,ex); 
                }   
            }
        }

        private void SessionManager_PlaybackStart(object sender, MediaBrowser.Controller.Library.PlaybackProgressEventArgs e)
        {
            var q = 1;
        }

        private Guid _id = new Guid("99fad2ca-dad4-40d9-b2c1-24f116529ccb");
        public override Guid Id
        {
            get { return _id; }
        }

        public static string PluginName = "Emby Sync";
        /// <summary>
        /// Gets the name of the plugin
        /// </summary>
        /// <value>The name.</value>
        public override string Name
        {
            get { return PluginName; }
        }

    }
}
