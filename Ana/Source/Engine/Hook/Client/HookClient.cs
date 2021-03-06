﻿namespace Ana.Source.Engine.Hook.Client
{
    using EasyHook;
    using Graphics;
    using Project;
    using SpeedHack;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.Remoting;

    /// <summary>
    /// Provides capability to access objects in the target process
    /// </summary>
    [Serializable]
    internal class HookClient : MarshalByRefObject, IHookClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HookClient" /> class
        /// </summary>
        public HookClient()
        {
        }

        /// <summary>
        /// Gets or sets the graphics interface shared between client and hook
        /// </summary>
        private IGraphicsInterface GraphicsInterface { get; set; }

        /// <summary>
        /// Gets or sets the speedhack interface shared between client and hook
        /// </summary>
        private ISpeedHackInterface SpeedHackInterface { get; set; }

        /// <summary>
        /// Injects the hook into the specified process
        /// </summary>
        /// <param name="process">The process to inject into</param>
        public void Inject(Process process)
        {
            // Skip if the process is already hooked, or if there is no main window
            if (this.GraphicsInterface != null || this.SpeedHackInterface != null || (process == null || process.MainWindowHandle == IntPtr.Zero))
            {
                return;
            }

            String projectDirectory = Path.GetDirectoryName(ProjectExplorerViewModel.GetInstance().ProjectFilePath);
            String channelName = null;

            this.GraphicsInterface = GraphicsFactory.GetGraphicsInterface(projectDirectory);
            this.SpeedHackInterface = new SpeedHackInterface();

            // Initialize the IPC server, giving the server access to the interfaces defined here
            RemoteHooking.IpcCreateServer<HookClient>(ref channelName, WellKnownObjectMode.Singleton, this);

            try
            {
                // Inject DLL into target process
                RemoteHooking.Inject(
                    process.Id,
                    InjectionOptions.Default,
                    typeof(HookClient).Assembly.Location,
                    typeof(HookClient).Assembly.Location,
                    channelName,
                    projectDirectory);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to Inject:" + ex);
            }
        }

        /// <summary>
        /// Gets the graphics interface hook object
        /// </summary>
        /// <returns>The graphics interface hook object</returns>
        public IGraphicsInterface GetGraphicsInterface()
        {
            return this.GraphicsInterface;
        }

        /// <summary>
        /// Gets the speed hack hook object
        /// </summary>
        /// <returns>The speed hack hook object</returns>
        public ISpeedHackInterface GetSpeedHackInterface()
        {
            return this.SpeedHackInterface;
        }

        /// <summary>
        /// Allows the server to ping the client to ensure that it is still alive
        /// </summary>
        public void Ping()
        {
        }

        /// <summary>
        /// Uninjects the hook from the external process
        /// </summary>
        public void Uninject()
        {
            this.GraphicsInterface = null;
            this.SpeedHackInterface = null;
        }
    }
    //// End class
}
//// End namespace