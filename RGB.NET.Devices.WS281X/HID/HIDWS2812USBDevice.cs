﻿// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

using System.Collections.Generic;
using System.Linq;
using RGB.NET.Core;

namespace RGB.NET.Devices.WS281X.HID
{
    // ReSharper disable once InconsistentNaming
    /// <inheritdoc cref="AbstractRGBDevice{T}" />
    /// <summary>
    /// Represents an arduino WS2812 device.
    /// </summary>
    public class HIDWS2812USBDevice : AbstractRGBDevice<HIDWS2812USBDeviceInfo>, ILedStripe
    {
        #region Properties & Fields

        /// <summary>
        /// Gets the update queue performing updates for this device.
        /// </summary>
        public HIDWS2812USBUpdateQueue UpdateQueue { get; }

        /// <inheritdoc />
        public override HIDWS2812USBDeviceInfo DeviceInfo { get; }

        /// <summary>
        /// Gets the channel (as defined in the firmware) this device is attached to.
        /// </summary>
        public int Channel { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HIDWS2812USBDevice"/> class.
        /// </summary>
        /// <param name="deviceInfo">The update trigger used by this queue.</param>
        /// <param name="updateQueue">The update queue performing updates for this device.</param>
        /// <param name="channel">The channel (as defined in the firmware) this device is attached to.</param>
        public HIDWS2812USBDevice(HIDWS2812USBDeviceInfo deviceInfo, HIDWS2812USBUpdateQueue updateQueue, int channel)
        {
            this.DeviceInfo = deviceInfo;
            this.UpdateQueue = updateQueue;
            this.Channel = channel;
        }

        #endregion

        #region Methods

        internal void Initialize(int ledCount)
        {
            for (int i = 0; i < ledCount; i++)
                AddLed(LedId.LedStripe1 + i, new Point(i * 10, 0), new Size(10, 10));
        }

        /// <inheritdoc />
        protected override object GetLedCustomData(LedId ledId) => (Channel, (int)ledId - (int)LedId.LedStripe1);
        
        /// <inheritdoc />
        protected override void UpdateLeds(IEnumerable<Led> ledsToUpdate) => UpdateQueue.SetData(ledsToUpdate.Where(x => x.Color.A > 0));

        /// <inheritdoc />
        public override void Dispose()
        {
            try { UpdateQueue.Dispose(); }
            catch { /* at least we tried */ }

            base.Dispose();
        }

        #endregion
    }
}
