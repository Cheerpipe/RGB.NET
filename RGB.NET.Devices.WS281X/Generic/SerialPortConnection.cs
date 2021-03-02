﻿using System.IO.Ports;

namespace RGB.NET.Devices.WS281X
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a serial-connection using the default microsoft serial-port implementation.
    /// </summary>
    public class SerialPortConnection : ISerialConnection
    {
        #region Properties & Fields

        /// <summary>
        /// The <see cref="System.IO.Ports.SerialPort"/> used for the connection.
        /// </summary>
        public SerialPort SerialPort { get; }

        /// <inheritdoc />
        public string Port => SerialPort.PortName;

        /// <inheritdoc />
        public int BaudRate => SerialPort.BaudRate;

        /// <inheritdoc />
        public bool IsOpen => SerialPort.IsOpen;

        #endregion

        #region Constructors

        public SerialPortConnection(string port, int baudRate, bool useFlowControl = false)
        {
            SerialPort = new SerialPort(port, baudRate);

            if (useFlowControl)
            {
                SerialPort.RtsEnable = true;
                SerialPort.DtrEnable = true;
            }
        }

        #endregion

        #region Methods

        /// <inheritdoc />
        public void Open() => SerialPort.Open();

        /// <inheritdoc />
        public void DiscardInBuffer() => SerialPort.DiscardInBuffer();

        /// <inheritdoc />
        public byte ReadByte() => (byte)SerialPort.ReadByte();

        /// <inheritdoc />
        public void ReadTo(char target) => SerialPort.ReadTo(target.ToString());

        /// <inheritdoc />
        public void Write(byte[] buffer, int offset, int length) => SerialPort.Write(buffer, offset, length);

        /// <inheritdoc />
        public void WriteLine(string line) => SerialPort.WriteLine(line);

        /// <inheritdoc />
        public void Dispose() => SerialPort.Dispose();

        #endregion
    }
}
