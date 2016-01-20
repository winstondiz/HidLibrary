// ReSharper disable MemberCanBePrivate.Global

namespace HidLibrary
{
    // ReSharper disable once ClassNeverInstantiated.Global
    
     /*Class for fix Bug with "OpenDivice()" reconect attributes error*/
    /*
    @author Alexander Lobanov
    @email:winstondiz@gmail.com
    */
    public class HidDeviceMode
    {
        public DeviceMode ReadMode { get; set; }
        public DeviceMode WriteMode { get; set; }
        public ShareMode ShareMode { get; set; }

        private readonly bool _needChangeStatus = true;

        public HidDeviceMode(DeviceMode readMode, DeviceMode writeMode, ShareMode shareMode)
        {
            if (!_needChangeStatus) return;
            /* 
            If the flag is "false", then we have the previous values of the attributes.
            Update the values is not required. 
            */
            ReadMode = readMode;
            WriteMode = writeMode;
            ShareMode = shareMode;
            _needChangeStatus = false;
        }

        /// <summary>
        /// Determining whether there is a previous connection attributes or not.
        /// </summary>
        /// <returns>If true - no previous attributes, false - otherwise.</returns>
        public bool IsDontHavePrevStatus() => _needChangeStatus;

        /// <summary>
        /// Function to change the operating mode of the device
        /// </summary>
        /// <returns>void</returns>
        public void ChangeDeviceMod(DeviceMode readMode, DeviceMode writeMode, ShareMode shareMode)
        {
            this.ReadMode = readMode;
            this.WriteMode = writeMode;
            this.ShareMode = shareMode;
        }

        public HidDeviceMode()
        {
        }
    }
}
