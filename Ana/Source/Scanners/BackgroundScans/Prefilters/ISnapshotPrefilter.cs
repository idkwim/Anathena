﻿namespace Ana.Source.Scanners.BackgroundScans.Prefilters
{
    using Ana.Source.Snapshots;

    /// <summary>
    /// Interface defining methods that a snapshot prefilter must implement
    /// </summary>
    internal interface ISnapshotPrefilter
    {
        /// <summary>
        /// Starts the prefilter
        /// </summary>
        void BeginPrefilter();

        /// <summary>
        /// Gets the snapshot generated by the prefilter
        /// </summary>
        /// <returns>The snapshot generated by the prefilter</returns>
        Snapshot GetPrefilteredSnapshot();
    }
    //// End interface
}
//// End namespace