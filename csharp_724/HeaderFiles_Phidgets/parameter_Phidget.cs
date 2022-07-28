using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using Phidget22;
using System.IO;

namespace csharp_724.parameter_Phidget
{
    internal class parameter_Phidget
    {
		public class commandLineData
		{
			private int deviceChannel, deviceSerial, devicePort;
			private string deviceLabel, networkServerName, serverpassword;
			private bool remoteDevice, localDevice, vintPortDevice;
			public commandLineData(int channel, int serialNumber, int hubPort, string label, string serverName, string password, bool isRemote, bool isLocal, bool isHubPort)
			{
				deviceChannel = channel;
				deviceSerial = serialNumber;
				devicePort = hubPort;
				deviceLabel = label;
				networkServerName = serverName;
				remoteDevice = isRemote;
				localDevice = isLocal;
				vintPortDevice = isHubPort;
				serverpassword = password;
			}

			#region properties
			public int Channel
			{
				get
				{
					return this.deviceChannel;
				}
			}
			public int SerialNumber
			{
				get
				{
					return this.deviceSerial;
				}
			}
			public int HubPort
			{
				get
				{
					return this.devicePort;
				}
			}
			public string Label
			{
				get
				{
					return this.deviceLabel;
				}
			}
			public string ServerName
			{
				get
				{
					return this.networkServerName;
				}
			}
			public bool isRemote
			{
				get
				{
					return this.remoteDevice;
				}
			}
			public bool isLocal
			{
				get
				{
					return this.localDevice;
				}
			}
			public bool isHubPortDevice
			{
				get
				{
					return this.vintPortDevice;
				}
			}
			public string Password
			{
				get
				{
					return this.serverpassword;
				}
			}
			#endregion

		}
	}
}
