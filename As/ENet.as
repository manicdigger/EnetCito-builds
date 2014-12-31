// Generated automatically with "cito". Do not edit.
package
{
	import flash.utils.ByteArray;

	public class ENet
	{
		public function ENet()
		{
			this.dummyCommand = new ENetIncomingCommand();
			this.commandSizes = new Array(13);
			this.commandSizes[0] = 0;
			this.commandSizes[1] = 8;
			this.commandSizes[2] = 48;
			this.commandSizes[3] = 44;
			this.commandSizes[4] = 8;
			this.commandSizes[5] = 4;
			this.commandSizes[6] = 6;
			this.commandSizes[7] = 8;
			this.commandSizes[8] = 24;
			this.commandSizes[9] = 8;
			this.commandSizes[10] = 12;
			this.commandSizes[11] = 16;
			this.commandSizes[12] = 24;
		}

		private function deserialize(a : ByteArray) : ENetProtocolHeader
		{
			var h : ENetProtocolHeader = new ENetProtocolHeader();
			h.peerID = this.readShort(a, 0);
			h.sentTime = this.readShort(a, 2);
			return h;
		}

		private function deserializeProtocolCommandCommand(readBuf : ByteArray, currentDataI : int, commandNumber : int, command : ENetProtocol) : void
		{
			var pos : int = currentDataI + 4;
			switch (commandNumber) {
			case 1:
				command.acknowledge = new ENetProtocolAcknowledge();
				command.acknowledge.receivedReliableSequenceNumber = this.readShort(readBuf, pos);
				pos += 2;
				command.acknowledge.receivedSentTime = this.readShort(readBuf, pos);
				pos += 2;
				break;
			case 2:
				command.connect = new ENetProtocolConnect();
				command.connect.outgoingPeerID = this.readShort(readBuf, pos);
				pos += 2;
				command.connect.incomingSessionID = this.readByte(readBuf, pos);
				pos += 1;
				command.connect.outgoingSessionID = this.readByte(readBuf, pos);
				pos += 1;
				command.connect.mtu = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.windowSize = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.channelCount = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.incomingBandwidth = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.outgoingBandwidth = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.packetThrottleInterval = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.packetThrottleAcceleration = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.packetThrottleDeceleration = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.connectID = this.readInt(readBuf, pos);
				pos += 4;
				command.connect.data = this.readInt(readBuf, pos);
				pos += 4;
				break;
			case 3:
				command.verifyConnect = new ENetProtocolVerifyConnect();
				command.verifyConnect.outgoingPeerID = this.readShort(readBuf, pos);
				pos += 2;
				command.verifyConnect.incomingSessionID = this.readByte(readBuf, pos);
				pos += 1;
				command.verifyConnect.outgoingSessionID = this.readByte(readBuf, pos);
				pos += 1;
				command.verifyConnect.mtu = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.windowSize = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.channelCount = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.incomingBandwidth = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.outgoingBandwidth = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.packetThrottleInterval = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.packetThrottleAcceleration = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.packetThrottleDeceleration = this.readInt(readBuf, pos);
				pos += 4;
				command.verifyConnect.connectID = this.readInt(readBuf, pos);
				pos += 4;
				break;
			case 4:
				command.disconnect = new ENetProtocolDisconnect();
				command.disconnect.data = this.readInt(readBuf, pos);
				pos += 4;
				break;
			case 5:
				command.ping = new ENetProtocolPing();
				break;
			case 6:
				command.sendReliable = new ENetProtocolSendReliable();
				command.sendReliable.dataLength = this.readShort(readBuf, pos);
				pos += 2;
				break;
			case 7:
				command.sendUnreliable = new ENetProtocolSendUnreliable();
				command.sendUnreliable.unreliableSequenceNumber = this.readShort(readBuf, pos);
				pos += 2;
				command.sendUnreliable.dataLength = this.readShort(readBuf, pos);
				pos += 2;
				break;
			case 9:
				command.sendUnsequenced = new ENetProtocolSendUnsequenced();
				command.sendUnsequenced.unsequencedGroup = this.readShort(readBuf, pos);
				pos += 2;
				command.sendUnsequenced.dataLength = this.readShort(readBuf, pos);
				pos += 2;
				break;
			case 8:
				command.sendFragment = new ENetProtocolSendFragment();
				command.sendFragment.startSequenceNumber = this.readShort(readBuf, pos);
				pos += 2;
				command.sendFragment.dataLength = this.readShort(readBuf, pos);
				pos += 2;
				command.sendFragment.fragmentCount = this.readInt(readBuf, pos);
				pos += 4;
				command.sendFragment.fragmentNumber = this.readInt(readBuf, pos);
				pos += 4;
				command.sendFragment.totalLength = this.readInt(readBuf, pos);
				pos += 4;
				command.sendFragment.fragmentOffset = this.readInt(readBuf, pos);
				pos += 4;
				break;
			case 10:
				command.bandwidthLimit = new ENetProtocolBandwidthLimit();
				command.bandwidthLimit.incomingBandwidth = this.readInt(readBuf, pos);
				pos += 4;
				command.bandwidthLimit.outgoingBandwidth = this.readInt(readBuf, pos);
				pos += 4;
				break;
			case 11:
				command.throttleConfigure = new ENetProtocolThrottleConfigure();
				command.throttleConfigure.packetThrottleInterval = this.readInt(readBuf, pos);
				pos += 4;
				command.throttleConfigure.packetThrottleAcceleration = this.readInt(readBuf, pos);
				pos += 4;
				command.throttleConfigure.packetThrottleDeceleration = this.readInt(readBuf, pos);
				pos += 4;
				break;
			case 12:
				command.sendFragment = new ENetProtocolSendFragment();
				command.sendFragment.startSequenceNumber = this.readShort(readBuf, pos);
				pos += 2;
				command.sendFragment.dataLength = this.readShort(readBuf, pos);
				pos += 2;
				command.sendFragment.fragmentCount = this.readInt(readBuf, pos);
				pos += 4;
				command.sendFragment.fragmentNumber = this.readInt(readBuf, pos);
				pos += 4;
				command.sendFragment.totalLength = this.readInt(readBuf, pos);
				pos += 4;
				command.sendFragment.fragmentOffset = this.readInt(readBuf, pos);
				pos += 4;
				break;
			default:
				break;
			}
		}

		private function deserializeProtocolCommandHeader(currentData : ByteArray, currentDataI : int) : ENetProtocol
		{
			var pos : int = currentDataI;
			var a : ENetProtocol = new ENetProtocol();
			a.header = new ENetProtocolCommandHeader();
			a.header.command = this.readByte(currentData, pos);
			pos += 1;
			a.header.channelID = this.readByte(currentData, pos);
			pos += 1;
			a.header.reliableSequenceNumber = this.readShort(currentData, pos);
			pos += 2;
			return a;
		}
		public static const E_N_E_T__B_U_F_F_E_R__M_A_X_I_M_U_M : int = 65;
		public static const E_N_E_T__H_O_S_T__A_N_Y : int = 0;
		public static const E_N_E_T__H_O_S_T__B_A_N_D_W_I_D_T_H__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L : int = 1000;
		public static const E_N_E_T__H_O_S_T__B_R_O_A_D_C_A_S_T : int = -1;
		public static const E_N_E_T__H_O_S_T__D_E_F_A_U_L_T__M_T_U : int = 1400;
		public static const E_N_E_T__H_O_S_T__R_E_C_E_I_V_E__B_U_F_F_E_R__S_I_Z_E : int = 262144;
		public static const E_N_E_T__H_O_S_T__S_E_N_D__B_U_F_F_E_R__S_I_Z_E : int = 262144;

		private function eNET_HOST_TO_NET_16(a : ushort) : ushort
		{
			return this.p.eNET_HOST_TO_NET_16(a);
		}

		private final function eNET_HOST_TO_NET_32(a : int) : int
		{
			return this.p.eNET_HOST_TO_NET_32(a);
		}

		private function eNET_MAX(x : int, y : int) : int
		{
			return x > y ? x : y;
		}

		private function eNET_MIN(x : int, y : int) : int
		{
			return x < y ? x : y;
		}

		private function eNET_NET_TO_HOST_16(a : ushort) : ushort
		{
			return this.p.eNET_NET_TO_HOST_16(a);
		}

		private function eNET_NET_TO_HOST_32(a : int) : int
		{
			return this.p.eNET_NET_TO_HOST_32(a);
		}
		public static const E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__P_A_C_K_E_T__T_H_R_O_T_T_L_E : int = 32;
		public static const E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__R_O_U_N_D__T_R_I_P__T_I_M_E : int = 500;
		public static const E_N_E_T__P_E_E_R__F_R_E_E__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S : int = 8;
		public static const E_N_E_T__P_E_E_R__F_R_E_E__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S : int = 32;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__I_N_T_E_R_V_A_L : int = 10000;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__S_C_A_L_E : int = 65536;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__A_C_C_E_L_E_R_A_T_I_O_N : int = 2;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__C_O_U_N_T_E_R : int = 7;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__D_E_C_E_L_E_R_A_T_I_O_N : int = 2;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L : int = 5000;
		public static const E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__S_C_A_L_E : int = 32;
		public static const E_N_E_T__P_E_E_R__P_I_N_G__I_N_T_E_R_V_A_L : int = 500;
		public static const E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S : int = 16;
		public static const E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W__S_I_Z_E : int = 4096;
		public static const E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__L_I_M_I_T : int = 32;
		public static const E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_A_X_I_M_U_M : int = 30000;
		public static const E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_I_N_I_M_U_M : int = 5000;
		public static const E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S : int = 64;
		public static const E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W__S_I_Z_E : int = 1024;
		public static const E_N_E_T__P_E_E_R__W_I_N_D_O_W__S_I_Z_E__S_C_A_L_E : int = 65536;
		public static const E_N_E_T__P_O_R_T__A_N_Y : int = 0;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__A_C_K_N_O_W_L_E_D_G_E : int = 1;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__B_A_N_D_W_I_D_T_H__L_I_M_I_T : int = 10;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_N_N_E_C_T : int = 2;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_U_N_T : int = 13;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__D_I_S_C_O_N_N_E_C_T : int = 4;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__A_C_K_N_O_W_L_E_D_G_E : int = 128;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D : int = 64;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__M_A_S_K : int = 15;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__N_O_N_E : int = 0;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__P_I_N_G : int = 5;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__F_R_A_G_M_E_N_T : int = 8;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__R_E_L_I_A_B_L_E : int = 6;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E : int = 7;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T : int = 12;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_S_E_Q_U_E_N_C_E_D : int = 9;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__T_H_R_O_T_T_L_E__C_O_N_F_I_G_U_R_E : int = 11;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__V_E_R_I_F_Y__C_O_N_N_E_C_T : int = 3;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__C_O_M_P_R_E_S_S_E_D : int = 16384;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__M_A_S_K : int = 49152;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__S_E_N_T__T_I_M_E : int = 32768;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__M_A_S_K : int = 12288;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__S_H_I_F_T : int = 12;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T : int = 255;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__F_R_A_G_M_E_N_T__C_O_U_N_T : int = 1048576;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__M_T_U : int = 4096;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__C_O_M_M_A_N_D_S : int = 32;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__S_I_Z_E : int = 1073741824;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_E_E_R__I_D : int = 4095;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__W_I_N_D_O_W__S_I_Z_E : int = 32768;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T : int = 1;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__M_T_U : int = 576;
		public static const E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__W_I_N_D_O_W__S_I_Z_E : int = 4096;
		public static const E_N_E_T__S_O_C_K_E_T__W_A_I_T__I_N_T_E_R_R_U_P_T : int = 4;
		public static const E_N_E_T__S_O_C_K_E_T__W_A_I_T__N_O_N_E : int = 0;
		public static const E_N_E_T__S_O_C_K_E_T__W_A_I_T__R_E_C_E_I_V_E : int = 2;
		public static const E_N_E_T__S_O_C_K_E_T__W_A_I_T__S_E_N_D : int = 1;

		private function eNET_TIME_DIFFERENCE(a : int, b : int) : int
		{
			return a - b < 0 ? b - a : a - b;
		}

		private final function eNET_TIME_GREATER(a : int, b : int) : Boolean
		{
			return b - a < 0;
		}

		private function eNET_TIME_GREATER_EQUAL(a : int, b : int) : Boolean
		{
			return !this.eNET_TIME_LESS(a, b);
		}

		private function eNET_TIME_LESS(a : int, b : int) : Boolean
		{
			return a - b < 0;
		}

		private final function eNET_TIME_LESS_EQUAL(a : int, b : int) : Boolean
		{
			return !this.eNET_TIME_GREATER(a, b);
		}

		public static function eNET_VERSION() : int
		{
			return ENet.eNET_VERSION_CREATE(1, 3, 8);
		}

		public static function eNET_VERSION_CREATE(major : int, minor : int, patch : int) : int
		{
			return major << 16 | minor << 8 | patch;
		}

		public static function eNET_VERSION_GET_MAJOR(version : int) : int
		{
			return version >> 16 & 255;
		}

		public static function eNET_VERSION_GET_MINOR(version : int) : int
		{
			return version >> 8 & 255;
		}

		public static function eNET_VERSION_GET_PATCH(version : int) : int
		{
			return version & 255;
		}
		public static const E_N_E_T__V_E_R_S_I_O_N__M_A_J_O_R : int = 1;
		public static const E_N_E_T__V_E_R_S_I_O_N__M_I_N_O_R : int = 3;
		public static const E_N_E_T__V_E_R_S_I_O_N__P_A_T_C_H : int = 8;

		private function readByte(currentData : ByteArray, currentDataI : int) : int
		{
			return currentData[currentDataI];
		}

		private function readInt(readBuf : ByteArray, readPos : int) : int
		{
			var n : int = readBuf[readPos + 3] << 24;
			n |= readBuf[readPos + 2] << 16;
			n |= readBuf[readPos + 1] << 8;
			n |= readBuf[readPos + 0];
			return n;
		}

		private function readShort(readBuf : ByteArray, readPos : int) : ushort
		{
			var n : int = readBuf[readPos + 1] << 8;
			n |= readBuf[readPos + 0];
			readPos += 2;
			return this.p.intToUshort(n);
		}
		public static const S_O_C_K_E_T__E_R_R_O_R : int = -1;

		private function serializeCommand(buf : ByteArray, a : ENetProtocol) : void
		{
			if (a == null) {
				a = new ENetProtocol();
			}
			var pos : Array = new Array(1);
			pos[0] = 0;
			this.writeByte(buf, pos, a.header.command);
			this.writeByte(buf, pos, a.header.channelID);
			this.writeShort(buf, pos, a.header.reliableSequenceNumber);
			switch (a.header.command & 15) {
			case 1:
				{
					this.writeShort(buf, pos, a.acknowledge.receivedReliableSequenceNumber);
					this.writeShort(buf, pos, a.acknowledge.receivedSentTime);
					break;
				}
			case 2:
				{
					this.writeShort(buf, pos, a.connect.outgoingPeerID);
					this.writeByte(buf, pos, a.connect.incomingSessionID);
					this.writeByte(buf, pos, a.connect.outgoingSessionID);
					this.writeInt(buf, pos, a.connect.mtu);
					this.writeInt(buf, pos, a.connect.windowSize);
					this.writeInt(buf, pos, a.connect.channelCount);
					this.writeInt(buf, pos, a.connect.incomingBandwidth);
					this.writeInt(buf, pos, a.connect.outgoingBandwidth);
					this.writeInt(buf, pos, a.connect.packetThrottleInterval);
					this.writeInt(buf, pos, a.connect.packetThrottleAcceleration);
					this.writeInt(buf, pos, a.connect.packetThrottleDeceleration);
					this.writeInt(buf, pos, a.connect.connectID);
					this.writeInt(buf, pos, a.connect.data);
					break;
				}
			case 3:
				{
					this.writeInt(buf, pos, a.connect.outgoingPeerID);
					this.writeByte(buf, pos, a.connect.incomingSessionID);
					this.writeByte(buf, pos, a.connect.outgoingSessionID);
					this.writeInt(buf, pos, a.connect.mtu);
					this.writeInt(buf, pos, a.connect.windowSize);
					this.writeInt(buf, pos, a.connect.channelCount);
					this.writeInt(buf, pos, a.connect.incomingBandwidth);
					this.writeInt(buf, pos, a.connect.outgoingBandwidth);
					this.writeInt(buf, pos, a.connect.packetThrottleInterval);
					this.writeInt(buf, pos, a.connect.packetThrottleAcceleration);
					this.writeInt(buf, pos, a.connect.packetThrottleDeceleration);
					this.writeInt(buf, pos, a.connect.connectID);
					break;
				}
			case 4:
				{
					this.writeInt(buf, pos, a.disconnect.data);
					break;
				}
			case 5:
				{
					break;
				}
			case 6:
				{
					this.writeShort(buf, pos, a.sendReliable.dataLength);
					break;
				}
			case 7:
				{
					this.writeShort(buf, pos, a.sendUnreliable.unreliableSequenceNumber);
					this.writeShort(buf, pos, a.sendUnreliable.dataLength);
					break;
				}
			case 8:
			case 12:
				{
					this.writeShort(buf, pos, a.sendFragment.startSequenceNumber);
					this.writeShort(buf, pos, a.sendFragment.dataLength);
					this.writeInt(buf, pos, a.sendFragment.fragmentCount);
					this.writeInt(buf, pos, a.sendFragment.fragmentNumber);
					this.writeInt(buf, pos, a.sendFragment.totalLength);
					this.writeInt(buf, pos, a.sendFragment.fragmentOffset);
					break;
				}
			case 9:
				{
					this.writeShort(buf, pos, a.sendUnsequenced.unsequencedGroup);
					this.writeShort(buf, pos, a.sendUnsequenced.dataLength);
					break;
				}
			case 10:
				{
					this.writeInt(buf, pos, a.bandwidthLimit.incomingBandwidth);
					this.writeInt(buf, pos, a.bandwidthLimit.outgoingBandwidth);
					break;
				}
			case 11:
				{
					this.writeInt(buf, pos, a.throttleConfigure.packetThrottleInterval);
					this.writeInt(buf, pos, a.throttleConfigure.packetThrottleAcceleration);
					this.writeInt(buf, pos, a.throttleConfigure.packetThrottleDeceleration);
					break;
				}
			}
		}

		private function serializeHeader(headerData : ByteArray, header : ENetProtocolHeader) : void
		{
			var pos : Array = new Array(1);
			pos[0] = 0;
			this.writeShort(headerData, pos, header.peerID);
			this.writeShort(headerData, pos, header.sentTime);
		}

		public final function setPlatform(value : ENetPlatform) : void
		{
			this.p = value;
		}

		public static function toByte(a : int) : int
		{
			return a & 0xff;
		}

		private function toUint16(a : int) : int
		{
			return this.p.intToUshort(a);
		}

		private function writeByte(data : ByteArray, pos : Array, value : int) : void
		{
			var pos_ : int = pos[0];
			data[pos_] = ENet.toByte(value);
			pos[0] += 1;
		}

		private function writeInt(data : ByteArray, pos : Array, n : int) : void
		{
			var pos_ : int = pos[0];
			data[pos_ + 3] = ENet.toByte(n >> 24 & 255);
			data[pos_ + 2] = ENet.toByte(n >> 16 & 255);
			data[pos_ + 1] = ENet.toByte(n >> 8 & 255);
			data[pos_ + 0] = ENet.toByte(n & 255);
			pos[0] += 4;
		}

		private function writeShort(data : ByteArray, pos : Array, value : int) : void
		{
			var pos_ : int = pos[0];
			data[pos_] = ENet.toByte(value & 255);
			data[pos_ + 1] = ENet.toByte(value >> 8 & 255);
			pos[0] += 2;
		}

		private function commandError(event_ : ENetEvent) : int
		{
			if (event_ != null && event_.type != ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
				return 1;
			return 0;
		}
		private var commandSizes : Array;
		private var crcTable : Array;
		private var dummyCommand : ENetIncomingCommand;

		public final function enet_address_set_host(address : ENetAddress, hostName : String) : int
		{
			return this.p.enet_address_set_host(address, hostName);
		}

		public final function enet_crc32(buffers : Array, bufferCount : int) : int
		{
			var crc : int = -1;
			if (!this.initializedCRC32)
				this.initialize_crc32();
			for (var buf : int = 0; buf < bufferCount; buf++) {
				var data : ByteArray = buffers[buf].data;
				var dataLength : int = buffers[buf].dataLength;
				for (var i : int = 0; i < dataLength; i++) {
					crc = crc >> 8 ^ this.crcTable[crc & 255 ^ data[i]];
				}
			}
			return this.p.eNET_HOST_TO_NET_32(~crc);
		}

		public final function enet_deinitialize() : void
		{
		}

		/**
		 * Adjusts the bandwidth limits of a host.
		 * @remarks the incoming and outgoing bandwidth parameters are identical in function to those
		 * specified in enet_host_create().
		 * @param host host to adjust
		 * @param incomingBandwidth new incoming bandwidth
		 * @param outgoingBandwidth new outgoing bandwidth
		 */
		public final function enet_host_bandwidth_limit(host : ENetHost, incomingBandwidth : int, outgoingBandwidth : int) : void
		{
			host.incomingBandwidth = incomingBandwidth;
			host.outgoingBandwidth = outgoingBandwidth;
			host.recalculateBandwidthLimits = 1;
		}

		private function enet_host_bandwidth_throttle(host : ENetHost) : void
		{
			var timeCurrent : int = this.p.enet_time_get();
			var elapsedTime : int = timeCurrent - host.bandwidthThrottleEpoch;
			var peersRemaining : int = host.connectedPeers;
			var dataTotal : int = ~0;
			var bandwidth : int = ~0;
			var throttle : int = 0;
			var bandwidthLimit : int = 0;
			var needsAdjustment : int = host.bandwidthLimitedPeers > 0 ? 1 : 0;
			var peer : ENetPeer;
			var command : ENetProtocol = new ENetProtocol();
			if (elapsedTime < 1000)
				return;
			host.bandwidthThrottleEpoch = timeCurrent;
			if (peersRemaining == 0)
				return;
			if (host.outgoingBandwidth != 0) {
				dataTotal = 0;
				bandwidth = int(host.outgoingBandwidth * elapsedTime / 1000);
				for (var i : int = 0; i < host.peerCount; i++) {
					peer = host.peers[i];
					if (peer.state != 5 && peer.state != 6)
						continue;
					dataTotal += peer.outgoingDataTotal;
				}
			}
			while (peersRemaining > 0 && needsAdjustment != 0) {
				needsAdjustment = 0;
				if (dataTotal <= bandwidth)
					throttle = 32;
				else
					throttle = int(bandwidth * 32 / dataTotal);
				for (var i : int = 0; i < host.peerCount; i++) {
					peer = host.peers[i];
					var peerBandwidth : int;
					if (peer.state != 5 && peer.state != 6 || peer.incomingBandwidth == 0 || peer.outgoingBandwidthThrottleEpoch == timeCurrent)
						continue;
					peerBandwidth = int(peer.incomingBandwidth * elapsedTime / 1000);
					if (int(throttle * peer.outgoingDataTotal / 32) <= peerBandwidth)
						continue;
					peer.packetThrottleLimit = int(peerBandwidth * 32 / peer.outgoingDataTotal);
					if (peer.packetThrottleLimit == 0)
						peer.packetThrottleLimit = 1;
					if (peer.packetThrottle > peer.packetThrottleLimit)
						peer.packetThrottle = peer.packetThrottleLimit;
					peer.outgoingBandwidthThrottleEpoch = timeCurrent;
					peer.incomingDataTotal = 0;
					peer.outgoingDataTotal = 0;
					needsAdjustment = 1;
					peersRemaining--;
					bandwidth -= peerBandwidth;
					dataTotal -= peerBandwidth;
				}
			}
			if (peersRemaining > 0) {
				if (dataTotal <= bandwidth)
					throttle = 32;
				else
					throttle = int(bandwidth * 32 / dataTotal);
				for (var i : int = 0; i < host.peerCount; i++) {
					peer = host.peers[i];
					if (peer.state != 5 && peer.state != 6 || peer.outgoingBandwidthThrottleEpoch == timeCurrent)
						continue;
					peer.packetThrottleLimit = throttle;
					if (peer.packetThrottle > peer.packetThrottleLimit)
						peer.packetThrottle = peer.packetThrottleLimit;
					peer.incomingDataTotal = 0;
					peer.outgoingDataTotal = 0;
				}
			}
			if (host.recalculateBandwidthLimits != 0) {
				host.recalculateBandwidthLimits = 0;
				peersRemaining = host.connectedPeers;
				bandwidth = host.incomingBandwidth;
				needsAdjustment = 1;
				if (bandwidth == 0)
					bandwidthLimit = 0;
				else
					while (peersRemaining > 0 && needsAdjustment != 0) {
						needsAdjustment = 0;
						bandwidthLimit = int(bandwidth / peersRemaining);
						for (var i : int = 0; i < host.peerCount; i++) {
							peer = host.peers[i];
							if (peer.state != 5 && peer.state != 6 || peer.incomingBandwidthThrottleEpoch == timeCurrent)
								continue;
							if (peer.outgoingBandwidth > 0 && peer.outgoingBandwidth >= bandwidthLimit)
								continue;
							peer.incomingBandwidthThrottleEpoch = timeCurrent;
							needsAdjustment = 1;
							peersRemaining--;
							bandwidth -= peer.outgoingBandwidth;
						}
					}
				for (var i : int = 0; i < host.peerCount; i++) {
					peer = host.peers[i];
					if (peer.state != 5 && peer.state != 6)
						continue;
					command.header.command = 138;
					command.header.channelID = 255;
					command.bandwidthLimit = new ENetProtocolBandwidthLimit();
					command.bandwidthLimit.outgoingBandwidth = this.p.eNET_HOST_TO_NET_32(host.outgoingBandwidth);
					if (peer.incomingBandwidthThrottleEpoch == timeCurrent)
						command.bandwidthLimit.incomingBandwidth = this.p.eNET_HOST_TO_NET_32(peer.outgoingBandwidth);
					else
						command.bandwidthLimit.incomingBandwidth = this.p.eNET_HOST_TO_NET_32(bandwidthLimit);
					this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
				}
			}
		}

		/**
		 * Queues a packet to be sent to all peers associated with the host.
		 * @param host host on which to broadcast the packet
		 * @param channelID channel on which to broadcast
		 * @param packet packet to broadcast
		 */
		public final function enet_host_broadcast(host : ENetHost, channelID : int, packet : ENetPacket) : void
		{
			var currentPeer : ENetPeer;
			for (var i : int = 0; i < host.peerCount; i++) {
				currentPeer = host.peers[i];
				if (currentPeer.state != 5)
					continue;
				this.enet_peer_send(currentPeer, channelID, packet);
			}
			if (packet.referenceCount == 0)
				this.enet_packet_destroy(packet);
		}

		/**
		 * Limits the maximum allowed channels of future incoming connections.
		 * @param host host to limit
		 * @param channelLimit the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT
		 */
		public final function enet_host_channel_limit(host : ENetHost, channelLimit : int) : void
		{
			if (channelLimit == 0 || channelLimit > 255)
				channelLimit = 255;
			else if (channelLimit < 1)
				channelLimit = 1;
			host.channelLimit = channelLimit;
		}

		/**
		 * Checks for any queued events on the host and dispatches one if available.
		 * @retval &gt; 0 if an event was dispatched
		 * @retval 0 if no events are available
		 * @retval &lt; 0 on failure
		 * @ingroup host
		 * @param host host to check for events
		 * @param event_ an event structure where event details will be placed if available
		 */
		public final function enet_host_check_events(host : ENetHost, event_ : ENetEvent) : int
		{
			if (event_ == null)
				return -1;
			event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E;
			event_.peer = null;
			event_.packet = null;
			return this.enet_protocol_dispatch_incoming_commands(host, event_);
		}

		/**
		 * Sets the packet compressor the host should use to compress and decompress packets.
		 * @param host host to enable or disable compression for
		 * @param compressor callbacks for for the packet compressor; if NULL, then compression is disabled
		 */
		public final function enet_host_compress(host : ENetHost, compressor : ENetCompressor) : void
		{
			if (host.compressor != null)
				host.compressor.destroy();
			if (compressor != null)
				host.compressor = compressor;
			else
				host.compressor = null;
		}

		/**
		 * Sets the packet compressor the host should use to the default range coder.
		 * @returns 0 on success, &lt; 0 on failure
		 * @param host @param host host to enable the range coder for
		 */
		public final function enet_host_compress_with_range_coder(host : ENetHost) : int
		{
			return 0;
		}

		/**
		 * Initiates a connection to a foreign host.
		 * @returns a peer representing the foreign host on success, NULL on failure
		 * @remarks The peer returned will have not completed the connection until enet_host_service()
		 * notifies of an ENET_EVENT_TYPE_CONNECT event for the peer.
		 * @param host host seeking the connection
		 * @param address destination for the connection
		 * @param channelCount number of channels to allocate
		 * @param data user data supplied to the receiving host 
		 */
		public final function enet_host_connect(host : ENetHost, address : ENetAddress, channelCount : int, data : int) : ENetPeer
		{
			var currentPeer : ENetPeer = null;
			var channel : ENetChannel;
			var command : ENetProtocol = new ENetProtocol();
			if (channelCount < 1)
				channelCount = 1;
			else if (channelCount > 255)
				channelCount = 255;
			for (var i : int = 0; i < host.peerCount; i++) {
				currentPeer = host.peers[i];
				if (currentPeer.state == 0)
					break;
			}
			if (host.peerCount == 0) {
				return null;
			}
			currentPeer.channels = new Array(channelCount);
			for (var i : int = 0; i < channelCount; i++) {
				currentPeer.channels[i] = new ENetChannel();
			}
			if (currentPeer.channels == null)
				return null;
			currentPeer.channelCount = channelCount;
			currentPeer.state = 1;
			currentPeer.address = ENetAddress.clone(address);
			currentPeer.connectID = ++host.randomSeed;
			if (host.outgoingBandwidth == 0)
				currentPeer.windowSize = 32768;
			else
				currentPeer.windowSize = int(host.outgoingBandwidth / 65536) * 4096;
			if (currentPeer.windowSize < 4096)
				currentPeer.windowSize = 4096;
			else if (currentPeer.windowSize > 32768)
				currentPeer.windowSize = 32768;
			for (var i : int = 0; i < channelCount; i++) {
				channel = currentPeer.channels[i];
				channel.outgoingReliableSequenceNumber = 0;
				channel.outgoingUnreliableSequenceNumber = 0;
				channel.incomingReliableSequenceNumber = 0;
				channel.incomingUnreliableSequenceNumber = 0;
				this.enet_list_clear(channel.incomingReliableCommands);
				this.enet_list_clear(channel.incomingUnreliableCommands);
				channel.usedReliableWindows = 0;
				for (var k : int = 0; k < 16; k++) {
					channel.reliableWindows[k] = 0;
				}
			}
			command.header = new ENetProtocolCommandHeader();
			command.header.command = 130;
			command.header.channelID = 255;
			command.connect = new ENetProtocolConnect();
			command.connect.outgoingPeerID = this.p.eNET_HOST_TO_NET_16(currentPeer.incomingPeerID);
			command.connect.incomingSessionID = currentPeer.incomingSessionID;
			command.connect.outgoingSessionID = currentPeer.outgoingSessionID;
			command.connect.mtu = this.p.eNET_HOST_TO_NET_32(currentPeer.mtu);
			command.connect.windowSize = this.p.eNET_HOST_TO_NET_32(currentPeer.windowSize);
			command.connect.channelCount = this.p.eNET_HOST_TO_NET_32(channelCount);
			command.connect.incomingBandwidth = this.p.eNET_HOST_TO_NET_32(host.incomingBandwidth);
			command.connect.outgoingBandwidth = this.p.eNET_HOST_TO_NET_32(host.outgoingBandwidth);
			command.connect.packetThrottleInterval = this.p.eNET_HOST_TO_NET_32(currentPeer.packetThrottleInterval);
			command.connect.packetThrottleAcceleration = this.p.eNET_HOST_TO_NET_32(currentPeer.packetThrottleAcceleration);
			command.connect.packetThrottleDeceleration = this.p.eNET_HOST_TO_NET_32(currentPeer.packetThrottleDeceleration);
			command.connect.connectID = currentPeer.connectID;
			command.connect.data = this.p.eNET_HOST_TO_NET_32(data);
			this.enet_peer_queue_outgoing_command(currentPeer, command, null, 0, 0);
			return currentPeer;
		}

		/**
		 * Creates a host for communicating to peers.  
		 * @remarks ENet will strategically drop packets on specific sides of a connection between hosts
		 * to ensure the host's bandwidth is not overwhelmed.  The bandwidth parameters also determine
		 * the window size of a connection which limits the amount of reliable packets that may be in transit
		 * at any given time.
		 * @returns the host on success and NULL on failure
		 * @param address the address at which other peers may connect to this host.  If NULL, then no peers may connect to the host.
		 * @param peerCount the maximum number of peers that should be allocated for the host.
		 * @param channelLimit the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT
		 * @param incomingBandwidth downstream bandwidth of the host in bytes/second; if 0, ENet will assume unlimited bandwidth.
		 * @param outgoingBandwidth upstream bandwidth of the host in bytes/second; if 0, ENet will assume unlimited bandwidth.
		 */
		public final function enet_host_create(address : ENetAddress, peerCount : int, channelLimit : int, incomingBandwidth : int, outgoingBandwidth : int) : ENetHost
		{
			var host : ENetHost;
			var currentPeer : ENetPeer;
			if (peerCount > 4095)
				return null;
			host = new ENetHost();
			if (host == null)
				return null;
			host.peers = new Array(peerCount);
			if (host.peers == null) {
				return null;
			}
			for (var i : int = 0; i < peerCount; i++) {
				host.peers[i] = new ENetPeer();
			}
			host.socket = this.p.enet_socket_create(2);
			if (host.socket != null && host.socket.nULL() || address != null && this.p.enet_socket_bind(host.socket, address) < 0) {
				if (host.socket != null && !host.socket.nULL())
					this.p.enet_socket_destroy(host.socket);
				return null;
			}
			this.p.enet_socket_set_option(host.socket, 1, 1);
			this.p.enet_socket_set_option(host.socket, 2, 1);
			this.p.enet_socket_set_option(host.socket, 3, 262144);
			this.p.enet_socket_set_option(host.socket, 4, 262144);
			if (address != null && this.p.enet_socket_get_address(host.socket, host.address) < 0)
				host.address = address;
			if (channelLimit == 0 || channelLimit > 255)
				channelLimit = 255;
			else if (channelLimit < 1)
				channelLimit = 1;
			host.randomSeed = 0;
			host.randomSeed += this.p.time();
			host.randomSeed = host.randomSeed << 16 | host.randomSeed >> 16;
			host.channelLimit = channelLimit;
			host.incomingBandwidth = incomingBandwidth;
			host.outgoingBandwidth = outgoingBandwidth;
			host.bandwidthThrottleEpoch = 0;
			host.recalculateBandwidthLimits = 0;
			host.mtu = 1400;
			host.peerCount = peerCount;
			host.commandCount = 0;
			host.bufferCount = 0;
			host.checksum = null;
			host.receivedAddress = new ENetAddress();
			host.receivedAddress.host = 0;
			host.receivedAddress.port = 0;
			host.receivedData = null;
			host.receivedDataLength = 0;
			host.totalSentData = 0;
			host.totalSentPackets = 0;
			host.totalReceivedData = 0;
			host.totalReceivedPackets = 0;
			host.connectedPeers = 0;
			host.bandwidthLimitedPeers = 0;
			host.compressor = null;
			host.intercept = null;
			host.dispatchQueue = new ENetPeer();
			host.dispatchQueue.setSentinel(new ENetPeer());
			this.enet_list_clear(host.dispatchQueue);
			for (var i : int = 0; i < host.peerCount; i++) {
				currentPeer = host.peers[i];
				currentPeer.host = host;
				currentPeer.incomingPeerID = this.p.intToUshort(i);
				currentPeer.outgoingSessionID = currentPeer.incomingSessionID = 255;
				currentPeer.data = null;
				this.enet_list_clear(currentPeer.acknowledgements);
				this.enet_list_clear(currentPeer.sentReliableCommands);
				this.enet_list_clear(currentPeer.sentUnreliableCommands);
				this.enet_list_clear(currentPeer.outgoingReliableCommands);
				this.enet_list_clear(currentPeer.outgoingUnreliableCommands);
				this.enet_list_clear(currentPeer.dispatchedCommands);
				this.enet_peer_reset(currentPeer);
			}
			return host;
		}

		/**
		 * Destroys the host and all resources associated with it.
		 * @param host pointer to the host to destroy
		 */
		public final function enet_host_destroy(host : ENetHost) : void
		{
			var currentPeer : ENetPeer;
			if (host == null)
				return;
			this.p.enet_socket_destroy(host.socket);
			for (var i : int = 0; i < host.peerCount; i++) {
				currentPeer = host.peers[i];
				this.enet_peer_reset(currentPeer);
			}
			if (host.compressor != null)
				host.compressor.destroy();
		}

		/**
		 * Sends any queued packets on the host specified to its designated peers.
		 * @remarks this function need only be used in circumstances where one wishes to send queued packets earlier than in a call to enet_host_service().
		 * @ingroup host
		 * @param host host to flush
		 */
		public final function enet_host_flush(host : ENetHost) : void
		{
			host.serviceTime = this.p.enet_time_get();
			this.enet_protocol_send_outgoing_commands(host, null, 0);
		}

		/**
		 * Waits for events on the host specified and shuttles packets between the host and its peers.
		 * enet_host_service should be called fairly regularly for adequate performance
		 * @ingroup host
		 * @retval &gt; 0 if an event occurred within the specified time limit
		 * @retval 0 if no event occurred
		 * @retval &lt; 0 on failure
		 * @param host host to service
		 * @param event_ an event structure where event details will be placed if one occurs
		 * if event == null then no events will be delivered
		 * @param timeout number of milliseconds that ENet should wait for events
		 */
		public final function enet_host_service(host : ENetHost, event_ : ENetEvent, timeout : int) : int
		{
			var waitCondition : Array = new Array(1);
			if (event_ != null) {
				event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E;
				event_.peer = null;
				event_.packet = null;
				switch (this.enet_protocol_dispatch_incoming_commands(host, event_)) {
				case 1:
					return 1;
				case -1:
					return -1;
				default:
					break;
				}
			}
			host.serviceTime = this.p.enet_time_get();
			timeout += host.serviceTime;
			do {
				if (this.eNET_TIME_DIFFERENCE(host.serviceTime, host.bandwidthThrottleEpoch) >= 1000)
					this.enet_host_bandwidth_throttle(host);
				switch (this.enet_protocol_send_outgoing_commands(host, event_, 1)) {
				case 1:
					return 1;
				case -1:
					return -1;
				default:
					break;
				}
				switch (this.enet_protocol_receive_incoming_commands(host, event_)) {
				case 1:
					return 1;
				case -1:
					return -1;
				default:
					break;
				}
				switch (this.enet_protocol_send_outgoing_commands(host, event_, 1)) {
				case 1:
					return 1;
				case -1:
					return -1;
				default:
					break;
				}
				if (event_ != null) {
					switch (this.enet_protocol_dispatch_incoming_commands(host, event_)) {
					case 1:
						return 1;
					case -1:
						return -1;
					default:
						break;
					}
				}
				do {
					host.serviceTime = this.p.enet_time_get();
					if (this.eNET_TIME_GREATER_EQUAL(host.serviceTime, timeout))
						return 0;
					waitCondition[0] = 6;
					if (this.p.enet_socket_wait(host.socket, waitCondition, this.eNET_TIME_DIFFERENCE(timeout, host.serviceTime)) != 0)
						return -1;
				}
				while ((waitCondition[0] & 4) != 0);
				host.serviceTime = this.p.enet_time_get();
			}
			while ((waitCondition[0] & 2) != 0);
			return 0;
		}

		public final function enet_initialize() : int
		{
			return 0;
		}

		private final function enet_list_back(list : ENetList) : ENetListNode
		{
			return this.p.castToENetListNode(this.p.castToENetListNode(list.getSentinel()).previous);
		}

		private function enet_list_begin(list : ENetList) : ENetListNode
		{
			return this.p.castToENetListNode(this.p.castToENetListNode(list.getSentinel()).next);
		}

		private function enet_list_clear(list : ENetList) : void
		{
			this.p.castToENetListNode(list.getSentinel()).next = list.getSentinel();
			this.p.castToENetListNode(list.getSentinel()).previous = list.getSentinel();
		}

		private function enet_list_empty(list : ENetList) : Boolean
		{
			return this.enet_list_begin(list) == this.enet_list_end(list);
		}

		private function enet_list_end(list : ENetList) : ENetListNode
		{
			return this.p.castToENetListNode(list.getSentinel());
		}

		private function enet_list_front(list : ENetList) : ENetListNode
		{
			return this.p.castToENetListNode(this.p.castToENetListNode(list.getSentinel()).next);
		}

		private function enet_list_insert(position : ENetListNode, data : ENetObject) : ENetListNode
		{
			var result : ENetListNode = this.p.castToENetListNode(data);
			result.previous = position.previous;
			result.next = position;
			this.p.castToENetListNode(result.previous).next = result;
			position.previous = result;
			return result;
		}

		private function enet_list_move(position : ENetListNode, dataFirst : ENetListNode, dataLast : ENetListNode) : ENetListNode
		{
			var first : ENetListNode = dataFirst;
			var last : ENetListNode = dataLast;
			this.p.castToENetListNode(first.previous).next = last.next;
			this.p.castToENetListNode(last.next).previous = first.previous;
			first.previous = position.previous;
			last.next = position;
			this.p.castToENetListNode(first.previous).next = first;
			position.previous = last;
			return first;
		}

		private function enet_list_next(iterator : ENetListNode) : ENetListNode
		{
			return this.p.castToENetListNode(iterator.next);
		}

		private function enet_list_previous(iterator : ENetListNode) : ENetListNode
		{
			return this.p.castToENetListNode(iterator.previous);
		}

		private function enet_list_remove(position : ENetListNode) : ENetListNode
		{
			this.p.castToENetListNode(position.previous).next = position.next;
			this.p.castToENetListNode(position.next).previous = position.previous;
			return position;
		}

		private final function enet_list_size(list : ENetList) : int
		{
			var size : int = 0;
			var position : ENetListNode;
			for (position = this.enet_list_begin(list); position != this.enet_list_end(list); position = this.enet_list_next(position))
				size++;
			return size;
		}

		/**
		 * Creates a packet that may be sent to a peer.
		 * @returns the packet on success, NULL on failure
		 * @param data initial contents of the packet's data; the packet's data will remain uninitialized if dataContents is NULL.
		 * @param dataLength size of the data allocated for this packet
		 * @param flags flags for this packet as described for the ENetPacket structure.
		 */
		public final function enet_packet_create(data : ByteArray, dataLength : int, flags : int) : ENetPacket
		{
			var packet : ENetPacket = new ENetPacket();
			if (packet == null)
				return null;
			if ((flags & 4) != 0)
				packet.data = data;
			else if (dataLength <= 0)
				packet.data = null;
			else {
				packet.data = new ByteArray();
				if (packet.data == null) {
					return null;
				}
				if (data != null) {
					for (var i : int = 0; i < dataLength; i++) {
						packet.data[i] = data[i];
					}
				}
			}
			packet.referenceCount = 0;
			packet.flags = flags;
			packet.dataLength = dataLength;
			packet.freeCallback = null;
			packet.userData = null;
			return packet;
		}

		/**
		 * Destroys the packet and deallocates its data.
		 * @param packet packet to be destroyed
		 */
		public final function enet_packet_destroy(packet : ENetPacket) : void
		{
			if (packet == null)
				return;
			if (packet.freeCallback != null)
				packet.freeCallback.run(packet);
			if ((packet.flags & 4) == 0 && packet.data != null) {
			}
		}

		public final function enet_packet_resize(packet : ENetPacket, dataLength : int) : int
		{
			var newData : ByteArray;
			if (dataLength <= packet.dataLength || (packet.flags & 4) != 0) {
				packet.dataLength = dataLength;
				return 0;
			}
			newData = new ByteArray();
			if (newData == null)
				return -1;
			this.memcpy(newData, packet.data, packet.dataLength);
			packet.data = newData;
			packet.dataLength = dataLength;
			return 0;
		}

		/**
		 * Request a disconnection from a peer.
		 * An ENET_EVENT_DISCONNECT event will be generated by enet_host_service()
		 * once the disconnection is complete.
		 * @param peer peer to request a disconnection
		 * @param data data describing the disconnection
		 */
		public final function enet_peer_disconnect(peer : ENetPeer, data : int) : void
		{
			var command : ENetProtocol = new ENetProtocol();
			if (peer.state == 7 || peer.state == 0 || peer.state == 8 || peer.state == 9)
				return;
			this.enet_peer_reset_queues(peer);
			command.header.command = 4;
			command.header.channelID = 255;
			command.disconnect.data = this.p.eNET_HOST_TO_NET_32(data);
			if (peer.state == 5 || peer.state == 6)
				command.header.command |= 128;
			else
				command.header.command |= 64;
			this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
			if (peer.state == 5 || peer.state == 6) {
				this.enet_peer_on_disconnect(peer);
				peer.state = 7;
			}
			else {
				this.enet_host_flush(peer.host);
				this.enet_peer_reset(peer);
			}
		}

		/**
		 * Request a disconnection from a peer, but only after all queued outgoing packets are sent.
		 * An ENET_EVENT_DISCONNECT event will be generated by enet_host_service()
		 * once the disconnection is complete.
		 * @param peer peer to request a disconnection
		 * @param data data describing the disconnection
		 */
		public final function enet_peer_disconnect_later(peer : ENetPeer, data : int) : void
		{
			if ((peer.state == 5 || peer.state == 6) && !(this.enet_list_empty(peer.outgoingReliableCommands) && this.enet_list_empty(peer.outgoingUnreliableCommands) && this.enet_list_empty(peer.sentReliableCommands))) {
				peer.state = 6;
				peer.eventData = data;
			}
			else
				this.enet_peer_disconnect(peer, data);
		}

		/**
		 * Force an immediate disconnection from a peer.
		 * @remarks No ENET_EVENT_DISCONNECT event will be generated. The foreign peer is not
		 * guarenteed to receive the disconnect notification, and is reset immediately upon
		 * return from this function.
		 * @param peer peer to disconnect
		 * @param data data describing the disconnection
		 */
		public final function enet_peer_disconnect_now(peer : ENetPeer, data : int) : void
		{
			var command : ENetProtocol = new ENetProtocol();
			if (peer.state == 0)
				return;
			if (peer.state != 9 && peer.state != 7) {
				this.enet_peer_reset_queues(peer);
				command.header.command = 68;
				command.header.channelID = 255;
				command.disconnect.data = this.p.eNET_HOST_TO_NET_32(data);
				this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
				this.enet_host_flush(peer.host);
			}
			this.enet_peer_reset(peer);
		}

		private function enet_peer_dispatch_incoming_reliable_commands(peer : ENetPeer, channel : ENetChannel) : void
		{
			var currentCommand : ENetListNode;
			for (currentCommand = this.enet_list_begin(channel.incomingReliableCommands); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
				var incomingCommand : ENetIncomingCommand = this.p.castToENetIncomingCommand(currentCommand);
				if (incomingCommand.fragmentsRemaining > 0 || incomingCommand.reliableSequenceNumber != this.p.intToUshort(channel.incomingReliableSequenceNumber + 1))
					break;
				channel.incomingReliableSequenceNumber = incomingCommand.reliableSequenceNumber;
				if (incomingCommand.fragmentCount > 0)
					channel.incomingReliableSequenceNumber += incomingCommand.fragmentCount - 1;
			}
			if (currentCommand == this.enet_list_begin(channel.incomingReliableCommands))
				return;
			channel.incomingUnreliableSequenceNumber = 0;
			this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), this.enet_list_begin(channel.incomingReliableCommands), this.enet_list_previous(currentCommand));
			if (peer.needsDispatch == 0) {
				this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
				peer.needsDispatch = 1;
			}
			if (!this.enet_list_empty(channel.incomingUnreliableCommands))
				this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
		}

		private function enet_peer_dispatch_incoming_unreliable_commands(peer : ENetPeer, channel : ENetChannel) : void
		{
			var droppedCommand : ENetListNode;
			var startCommand : ENetListNode;
			var currentCommand : ENetListNode;
			for (droppedCommand = startCommand = currentCommand = this.enet_list_begin(channel.incomingUnreliableCommands); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
				var incomingCommand : ENetIncomingCommand = this.p.castToENetIncomingCommand(currentCommand);
				if ((incomingCommand.command.header.command & 15) == 9)
					continue;
				if (incomingCommand.reliableSequenceNumber == channel.incomingReliableSequenceNumber) {
					if (incomingCommand.fragmentsRemaining <= 0) {
						channel.incomingUnreliableSequenceNumber = incomingCommand.unreliableSequenceNumber;
						continue;
					}
					if (startCommand != currentCommand) {
						this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), startCommand, this.enet_list_previous(currentCommand));
						if (peer.needsDispatch == 0) {
							this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
							peer.needsDispatch = 1;
						}
						droppedCommand = currentCommand;
					}
					else if (droppedCommand != currentCommand)
						droppedCommand = this.enet_list_previous(currentCommand);
				}
				else {
					var reliableWindow : ushort = this.p.intToUshort(int(incomingCommand.reliableSequenceNumber / 4096));
					var currentWindow : ushort = this.p.intToUshort(int(channel.incomingReliableSequenceNumber / 4096));
					if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
						reliableWindow += 16;
					if (reliableWindow >= currentWindow && reliableWindow < currentWindow + 8 - 1)
						break;
					droppedCommand = this.enet_list_next(currentCommand);
					if (startCommand != currentCommand) {
						this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), startCommand, this.enet_list_previous(currentCommand));
						if (peer.needsDispatch == 0) {
							this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
							peer.needsDispatch = 1;
						}
					}
				}
				startCommand = this.enet_list_next(currentCommand);
			}
			if (startCommand != currentCommand) {
				this.enet_list_move(this.enet_list_end(peer.dispatchedCommands), startCommand, this.enet_list_previous(currentCommand));
				if (peer.needsDispatch == 0) {
					this.enet_list_insert(this.enet_list_end(peer.host.dispatchQueue), peer.dispatchList());
					peer.needsDispatch = 1;
				}
				droppedCommand = currentCommand;
			}
			this.enet_peer_remove_incoming_commands(channel.incomingUnreliableCommands, this.enet_list_begin(channel.incomingUnreliableCommands), droppedCommand);
		}

		private function enet_peer_on_connect(peer : ENetPeer) : void
		{
			if (peer.state != 5 && peer.state != 6) {
				if (peer.incomingBandwidth != 0)
					peer.host.bandwidthLimitedPeers++;
				peer.host.connectedPeers++;
			}
		}

		private function enet_peer_on_disconnect(peer : ENetPeer) : void
		{
			if (peer.state == 5 || peer.state == 6) {
				if (peer.incomingBandwidth != 0)
					peer.host.bandwidthLimitedPeers--;
				peer.host.connectedPeers--;
			}
		}

		/**
		 * Sends a ping request to a peer.
		 * ping requests factor into the mean round trip time as designated by the 
		 * roundTripTime field in the ENetPeer structure.  Enet automatically pings all connected
		 * peers at regular intervals, however, this function may be called to ensure more
		 * frequent ping requests.
		 * @param peer destination for the ping request
		 */
		public final function enet_peer_ping(peer : ENetPeer) : void
		{
			var command : ENetProtocol = new ENetProtocol();
			if (peer.state != 5)
				return;
			command.header.command = 133;
			command.header.channelID = 255;
			this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
		}

		/**
		 * Sets the interval at which pings will be sent to a peer. 
		 * Pings are used both to monitor the liveness of the connection and also to dynamically
		 * adjust the throttle during periods of low traffic so that the throttle has reasonable
		 * responsiveness during traffic spikes.
		 * @param peer the peer to adjust
		 * @param pingInterval the interval at which to send pings; defaults to ENET_PEER_PING_INTERVAL if 0
		 */
		public final function enet_peer_ping_interval(peer : ENetPeer, pingInterval : int) : void
		{
			peer.pingInterval = pingInterval != 0 ? pingInterval : 500;
		}

		private function enet_peer_queue_acknowledgement(peer : ENetPeer, command : ENetProtocol, sentTime : ushort) : ENetAcknowledgement
		{
			var acknowledgement : ENetAcknowledgement;
			if (command.header.channelID < peer.channelCount) {
				var channel : ENetChannel = peer.channels[command.header.channelID];
				var reliableWindow : ushort = this.p.intToUshort(int(command.header.reliableSequenceNumber / 4096));
				var currentWindow : ushort = this.p.intToUshort(int(channel.incomingReliableSequenceNumber / 4096));
				if (command.header.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
					reliableWindow += 16;
				if (reliableWindow >= currentWindow + 8 - 1 && reliableWindow <= currentWindow + 8)
					return null;
			}
			acknowledgement = new ENetAcknowledgement();
			if (acknowledgement == null)
				return null;
			peer.outgoingDataTotal += 8;
			acknowledgement.sentTime = sentTime;
			acknowledgement.command = command;
			this.enet_list_insert(this.enet_list_end(peer.acknowledgements), acknowledgement);
			return acknowledgement;
		}

		private function enet_peer_queue_incoming_command(peer : ENetPeer, command : ENetProtocol, packet : ENetPacket, fragmentCount : int) : ENetIncomingCommand
		{
			var channel : ENetChannel = peer.channels[command.header.channelID];
			var unreliableSequenceNumber : int = 0;
			var reliableSequenceNumber : int = 0;
			var reliableWindow : int;
			var currentWindow : int;
			var incomingCommand : ENetIncomingCommand = null;
			var currentCommand : ENetListNode;
			if (peer.state == 6) {
				return this.freePacket(fragmentCount, packet);
			}
			if ((command.header.command & 15) != 9) {
				reliableSequenceNumber = command.header.reliableSequenceNumber;
				reliableWindow = int(reliableSequenceNumber / 4096);
				currentWindow = int(channel.incomingReliableSequenceNumber / 4096);
				if (reliableSequenceNumber < channel.incomingReliableSequenceNumber)
					reliableWindow += 16;
				if (reliableWindow < currentWindow || reliableWindow >= currentWindow + 8 - 1) {
					return this.freePacket(fragmentCount, packet);
				}
			}
			switch (command.header.command & 15) {
			case 8:
			case 6:
				if (reliableSequenceNumber == channel.incomingReliableSequenceNumber)
					return this.freePacket(fragmentCount, packet);
				for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingReliableCommands)); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
					incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
					if (reliableSequenceNumber >= channel.incomingReliableSequenceNumber) {
						if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
							continue;
					}
					else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
						break;
					if (incomingCommand.reliableSequenceNumber <= reliableSequenceNumber) {
						if (incomingCommand.reliableSequenceNumber < reliableSequenceNumber)
							break;
						return this.freePacket(fragmentCount, packet);
					}
				}
				break;
			case 7:
			case 12:
				unreliableSequenceNumber = this.p.eNET_NET_TO_HOST_16(command.sendUnreliable.unreliableSequenceNumber);
				if (reliableSequenceNumber == channel.incomingReliableSequenceNumber && unreliableSequenceNumber <= channel.incomingUnreliableSequenceNumber)
					return this.freePacket(fragmentCount, packet);
				for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingUnreliableCommands)); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
					incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
					if ((command.header.command & 15) == 9)
						continue;
					if (reliableSequenceNumber >= channel.incomingReliableSequenceNumber) {
						if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
							continue;
					}
					else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
						break;
					if (incomingCommand.reliableSequenceNumber < reliableSequenceNumber)
						break;
					if (incomingCommand.reliableSequenceNumber > reliableSequenceNumber)
						continue;
					if (incomingCommand.unreliableSequenceNumber <= unreliableSequenceNumber) {
						if (incomingCommand.unreliableSequenceNumber < unreliableSequenceNumber)
							break;
						return this.freePacket(fragmentCount, packet);
					}
				}
				break;
			case 9:
				currentCommand = this.enet_list_end(channel.incomingUnreliableCommands);
				break;
			default:
				return this.freePacket(fragmentCount, packet);
			}
			incomingCommand = new ENetIncomingCommand();
			if (incomingCommand == null)
				return this.notifyError(packet);
			incomingCommand.reliableSequenceNumber = command.header.reliableSequenceNumber;
			incomingCommand.unreliableSequenceNumber = this.p.intToUshort(unreliableSequenceNumber & 65535);
			incomingCommand.command = command;
			incomingCommand.fragmentCount = fragmentCount;
			incomingCommand.fragmentsRemaining = fragmentCount;
			incomingCommand.packet = packet;
			incomingCommand.fragments = null;
			if (fragmentCount > 0) {
				if (fragmentCount <= 1048576)
					incomingCommand.fragments = new Array(int((fragmentCount + 31) / 32));
				if (incomingCommand.fragments == null) {
					return this.notifyError(packet);
				}
				for (var i : int = 0; i < int((fragmentCount + 31) / 32); i++) {
					incomingCommand.fragments[i] = 0;
				}
			}
			if (packet != null)
				packet.referenceCount++;
			this.enet_list_insert(this.enet_list_next(currentCommand), incomingCommand);
			switch (command.header.command & 15) {
			case 8:
			case 6:
				this.enet_peer_dispatch_incoming_reliable_commands(peer, channel);
				break;
			default:
				this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
				break;
			}
			return incomingCommand;
		}

		private function enet_peer_queue_outgoing_command(peer : ENetPeer, command : ENetProtocol, packet : ENetPacket, offset : int, length : ushort) : ENetOutgoingCommand
		{
			var outgoingCommand : ENetOutgoingCommand = new ENetOutgoingCommand();
			if (outgoingCommand == null)
				return null;
			outgoingCommand.command = command;
			outgoingCommand.fragmentOffset = offset;
			outgoingCommand.fragmentLength = length;
			outgoingCommand.packet = packet;
			if (packet != null)
				packet.referenceCount++;
			this.enet_peer_setup_outgoing_command(peer, outgoingCommand);
			return outgoingCommand;
		}

		/**
		 * Attempts to dequeue any incoming queued packet.
		 * @returns a pointer to the packet, or NULL if there are no available incoming queued packets
		 * @param peer peer to dequeue packets from
		 * @param channelID holds the channel ID of the channel the packet was received on success
		 */
		public final function enet_peer_receive(peer : ENetPeer, channelID : Byte) : ENetPacket
		{
			var incomingCommand : ENetIncomingCommand;
			var packet : ENetPacket;
			if (this.enet_list_empty(peer.dispatchedCommands))
				return null;
			incomingCommand = this.p.castToENetIncomingCommand(this.enet_list_remove(this.enet_list_begin(peer.dispatchedCommands)));
			if (channelID != null)
				channelID.value = incomingCommand.command.header.channelID;
			packet = incomingCommand.packet;
			packet.referenceCount--;
			if (incomingCommand.fragments != null) {
			}
			return packet;
		}

		public final function enet_peer_remove_incoming_commands(queue : ENetList, startCommand : ENetListNode, endCommand : ENetListNode) : void
		{
			var currentCommand : ENetListNode;
			for (currentCommand = startCommand; currentCommand != endCommand;) {
				var incomingCommand : ENetIncomingCommand = this.p.castToENetIncomingCommand(currentCommand);
				currentCommand = this.enet_list_next(currentCommand);
				this.enet_list_remove(incomingCommand.incomingCommandList());
				if (incomingCommand.packet != null) {
					incomingCommand.packet.referenceCount--;
					if (incomingCommand.packet.referenceCount == 0)
						this.enet_packet_destroy(incomingCommand.packet);
				}
				if (incomingCommand.fragments != null) {
				}
			}
		}

		/**
		 * Forcefully disconnects a peer.
		 * The foreign host represented by the peer is not notified of the disconnection and will timeout
		 * on its connection to the local host.
		 * @param peer peer to forcefully disconnect
		 */
		public final function enet_peer_reset(peer : ENetPeer) : void
		{
			this.enet_peer_on_disconnect(peer);
			peer.outgoingPeerID = 4095;
			peer.connectID = 0;
			peer.state = 0;
			peer.incomingBandwidth = 0;
			peer.outgoingBandwidth = 0;
			peer.incomingBandwidthThrottleEpoch = 0;
			peer.outgoingBandwidthThrottleEpoch = 0;
			peer.incomingDataTotal = 0;
			peer.outgoingDataTotal = 0;
			peer.lastSendTime = 0;
			peer.lastReceiveTime = 0;
			peer.nextTimeout = 0;
			peer.earliestTimeout = 0;
			peer.packetLossEpoch = 0;
			peer.packetsSent = 0;
			peer.packetsLost = 0;
			peer.packetLoss = 0;
			peer.packetLossVariance = 0;
			peer.packetThrottle = 32;
			peer.packetThrottleLimit = 32;
			peer.packetThrottleCounter = 0;
			peer.packetThrottleEpoch = 0;
			peer.packetThrottleAcceleration = 2;
			peer.packetThrottleDeceleration = 2;
			peer.packetThrottleInterval = 5000;
			peer.pingInterval = 500;
			peer.timeoutLimit = 32;
			peer.timeoutMinimum = 5000;
			peer.timeoutMaximum = 30000;
			peer.lastRoundTripTime = 500;
			peer.lowestRoundTripTime = 500;
			peer.lastRoundTripTimeVariance = 0;
			peer.highestRoundTripTimeVariance = 0;
			peer.roundTripTime = 500;
			peer.roundTripTimeVariance = 0;
			peer.mtu = peer.host.mtu;
			peer.reliableDataInTransit = 0;
			peer.outgoingReliableSequenceNumber = 0;
			peer.windowSize = 32768;
			peer.incomingUnsequencedGroup = 0;
			peer.outgoingUnsequencedGroup = 0;
			peer.eventData = 0;
			for (var i : int = 0; i < 32; i++) {
				peer.unsequencedWindow[i] = 0;
			}
			this.enet_peer_reset_queues(peer);
		}

		public final function enet_peer_reset_incoming_commands(queue : ENetList) : void
		{
			this.enet_peer_remove_incoming_commands(queue, this.enet_list_begin(queue), this.enet_list_end(queue));
		}

		public final function enet_peer_reset_outgoing_commands(queue : ENetList) : void
		{
			var outgoingCommand : ENetOutgoingCommand;
			while (!this.enet_list_empty(queue)) {
				outgoingCommand = this.p.castToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(queue)));
				if (outgoingCommand.packet != null) {
					outgoingCommand.packet.referenceCount--;
					if (outgoingCommand.packet.referenceCount == 0)
						this.enet_packet_destroy(outgoingCommand.packet);
				}
			}
		}

		public final function enet_peer_reset_queues(peer : ENetPeer) : void
		{
			var channel : ENetChannel;
			if (peer.needsDispatch != 0) {
				this.enet_list_remove(peer.dispatchList());
				peer.needsDispatch = 0;
			}
			while (!this.enet_list_empty(peer.acknowledgements)) {
				var n : ENetListNode = this.enet_list_remove(this.enet_list_begin(peer.acknowledgements));
			}
			this.enet_peer_reset_outgoing_commands(peer.sentReliableCommands);
			this.enet_peer_reset_outgoing_commands(peer.sentUnreliableCommands);
			this.enet_peer_reset_outgoing_commands(peer.outgoingReliableCommands);
			this.enet_peer_reset_outgoing_commands(peer.outgoingUnreliableCommands);
			this.enet_peer_reset_incoming_commands(peer.dispatchedCommands);
			if (peer.channels != null && peer.channelCount > 0) {
				for (var i : int = 0; i < peer.channelCount; i++) {
					channel = peer.channels[i];
					this.enet_peer_reset_incoming_commands(channel.incomingReliableCommands);
					this.enet_peer_reset_incoming_commands(channel.incomingUnreliableCommands);
				}
			}
			peer.channels = null;
			peer.channelCount = 0;
		}

		/**
		 * Queues a packet to be sent.
		 * @retval 0 on success
		 * @retval &lt; 0 on failure
		 * @param peer destination for the packet
		 * @param channelID channel on which to send
		 * @param packet packet to send
		 */
		public final function enet_peer_send(peer : ENetPeer, channelID : int, packet : ENetPacket) : int
		{
			var channel : ENetChannel = peer.channels[channelID];
			var command : ENetProtocol = new ENetProtocol();
			var fragmentLength : int;
			if (peer.state != 5 || channelID >= peer.channelCount || packet.dataLength > 1073741824)
				return -1;
			fragmentLength = peer.mtu - 4 - 28;
			if (peer.host.checksum != null)
				fragmentLength -= 4;
			if (packet.dataLength > fragmentLength) {
				var fragmentCount : int = int((packet.dataLength + fragmentLength - 1) / fragmentLength);
				var fragmentNumber : int;
				var fragmentOffset : int;
				var commandNumber : int;
				var startSequenceNumber : ushort;
				var fragments : ENetList = null;
				var fragment : ENetOutgoingCommand;
				if (fragmentCount > 1048576)
					return -1;
				if ((packet.flags & 9) == 8 && channel.outgoingUnreliableSequenceNumber < 65535) {
					commandNumber = 12;
					startSequenceNumber = this.p.eNET_HOST_TO_NET_16(this.p.intToUshort(channel.outgoingUnreliableSequenceNumber + 1));
				}
				else {
					commandNumber = 136;
					startSequenceNumber = this.p.eNET_HOST_TO_NET_16(this.p.intToUshort(channel.outgoingReliableSequenceNumber + 1));
				}
				this.enet_list_clear(fragments);
				fragmentNumber = 0;
				fragmentOffset = 0;
				while (fragmentOffset < packet.dataLength) {
					if (packet.dataLength - fragmentOffset < fragmentLength)
						fragmentLength = packet.dataLength - fragmentOffset;
					fragment = new ENetOutgoingCommand();
					if (fragment == null) {
						while (!this.enet_list_empty(fragments)) {
							fragment = this.p.castToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(fragments)).data);
						}
						return -1;
					}
					fragment.fragmentOffset = fragmentOffset;
					fragment.fragmentLength = this.p.intToUshort(fragmentLength);
					fragment.packet = packet;
					fragment.command.header.command = commandNumber;
					fragment.command.header.channelID = channelID;
					fragment.command.sendFragment.startSequenceNumber = startSequenceNumber;
					fragment.command.sendFragment.dataLength = this.p.eNET_HOST_TO_NET_16(this.p.intToUshort(fragmentLength));
					fragment.command.sendFragment.fragmentCount = this.p.eNET_HOST_TO_NET_32(fragmentCount);
					fragment.command.sendFragment.fragmentNumber = this.p.eNET_HOST_TO_NET_32(fragmentNumber);
					fragment.command.sendFragment.totalLength = this.p.eNET_HOST_TO_NET_32(packet.dataLength);
					fragment.command.sendFragment.fragmentOffset = this.p.eNET_NET_TO_HOST_32(fragmentOffset);
					this.enet_list_insert(this.enet_list_end(fragments), fragment);
					fragmentNumber++;
					fragmentOffset += fragmentLength;
				}
				packet.referenceCount += fragmentNumber;
				while (!this.enet_list_empty(fragments)) {
					fragment = this.p.castToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(fragments)));
					this.enet_peer_setup_outgoing_command(peer, fragment);
				}
				return 0;
			}
			command.header.channelID = channelID;
			if ((packet.flags & 3) == 2) {
				command.header.command = 73;
				command.sendUnsequenced.dataLength = this.p.eNET_HOST_TO_NET_16(this.p.intToUshort(packet.dataLength));
			}
			else if ((packet.flags & 1) != 0 || channel.outgoingUnreliableSequenceNumber >= 65535) {
				command.header.command = 134;
				command.sendReliable = new ENetProtocolSendReliable();
				command.sendReliable.dataLength = this.p.eNET_HOST_TO_NET_16(this.p.intToUshort(packet.dataLength));
			}
			else {
				command.header.command = 7;
				command.sendUnreliable = new ENetProtocolSendUnreliable();
				command.sendUnreliable.dataLength = this.p.eNET_HOST_TO_NET_16(this.p.intToUshort(packet.dataLength));
			}
			if (this.enet_peer_queue_outgoing_command(peer, command, packet, 0, this.p.intToUshort(packet.dataLength)) == null)
				return -1;
			return 0;
		}

		public final function enet_peer_setup_outgoing_command(peer : ENetPeer, outgoingCommand : ENetOutgoingCommand) : void
		{
			var channel : ENetChannel = null;
			peer.outgoingDataTotal += this.enet_protocol_command_size(outgoingCommand.command.header.command) + outgoingCommand.fragmentLength;
			if (outgoingCommand.command.header.channelID == 255) {
				peer.outgoingReliableSequenceNumber++;
				outgoingCommand.reliableSequenceNumber = peer.outgoingReliableSequenceNumber;
				outgoingCommand.unreliableSequenceNumber = 0;
			}
			else {
				channel = peer.channels[outgoingCommand.command.header.channelID];
				if ((outgoingCommand.command.header.command & 128) != 0) {
					channel.outgoingReliableSequenceNumber++;
					channel.outgoingUnreliableSequenceNumber = 0;
					outgoingCommand.reliableSequenceNumber = channel.outgoingReliableSequenceNumber;
					outgoingCommand.unreliableSequenceNumber = 0;
				}
				else if ((outgoingCommand.command.header.command & 64) != 0) {
					peer.outgoingUnsequencedGroup++;
					outgoingCommand.reliableSequenceNumber = 0;
					outgoingCommand.unreliableSequenceNumber = 0;
				}
				else {
					if (outgoingCommand.fragmentOffset == 0)
						channel.outgoingUnreliableSequenceNumber++;
					outgoingCommand.reliableSequenceNumber = channel.outgoingReliableSequenceNumber;
					outgoingCommand.unreliableSequenceNumber = channel.outgoingUnreliableSequenceNumber;
				}
			}
			outgoingCommand.sendAttempts = 0;
			outgoingCommand.sentTime = 0;
			outgoingCommand.roundTripTimeout = 0;
			outgoingCommand.roundTripTimeoutLimit = 0;
			outgoingCommand.command.header.reliableSequenceNumber = this.p.eNET_HOST_TO_NET_16(outgoingCommand.reliableSequenceNumber);
			switch (outgoingCommand.command.header.command & 15) {
			case 7:
				outgoingCommand.command.sendUnreliable.unreliableSequenceNumber = this.p.eNET_HOST_TO_NET_16(outgoingCommand.unreliableSequenceNumber);
				break;
			case 9:
				outgoingCommand.command.sendUnsequenced.unsequencedGroup = this.p.eNET_HOST_TO_NET_16(peer.outgoingUnsequencedGroup);
				break;
			default:
				break;
			}
			if ((outgoingCommand.command.header.command & 128) != 0)
				this.enet_list_insert(this.enet_list_end(peer.outgoingReliableCommands), outgoingCommand);
			else
				this.enet_list_insert(this.enet_list_end(peer.outgoingUnreliableCommands), outgoingCommand);
		}

		private function enet_peer_throttle(peer : ENetPeer, rtt : int) : int
		{
			if (peer.lastRoundTripTime <= peer.lastRoundTripTimeVariance) {
				peer.packetThrottle = peer.packetThrottleLimit;
			}
			else if (rtt < peer.lastRoundTripTime) {
				peer.packetThrottle += peer.packetThrottleAcceleration;
				if (peer.packetThrottle > peer.packetThrottleLimit)
					peer.packetThrottle = peer.packetThrottleLimit;
				return 1;
			}
			else if (rtt > peer.lastRoundTripTime + 2 * peer.lastRoundTripTimeVariance) {
				if (peer.packetThrottle > peer.packetThrottleDeceleration)
					peer.packetThrottle -= peer.packetThrottleDeceleration;
				else
					peer.packetThrottle = 0;
				return -1;
			}
			return 0;
		}

		/**
		 * @defgroup peer ENet peer functions 
		 * Configures throttle parameter for a peer.
		 * Unreliable packets are dropped by ENet in response to the varying conditions
		 * of the Internet connection to the peer.  The throttle represents a probability
		 * that an unreliable packet should not be dropped and thus sent by ENet to the peer.
		 * The lowest mean round trip time from the sending of a reliable packet to the
		 * receipt of its acknowledgement is measured over an amount of time specified by
		 * the interval parameter in milliseconds.  If a measured round trip time happens to
		 * be significantly less than the mean round trip time measured over the interval, 
		 * then the throttle probability is increased to allow more traffic by an amount
		 * specified in the acceleration parameter, which is a ratio to the ENET_PEER_PACKET_THROTTLE_SCALE
		 * constant.  If a measured round trip time happens to be significantly greater than
		 * the mean round trip time measured over the interval, then the throttle probability
		 * is decreased to limit traffic by an amount specified in the deceleration parameter, which
		 * is a ratio to the ENET_PEER_PACKET_THROTTLE_SCALE constant.  When the throttle has
		 * a value of ENET_PEER_PACKET_THROTTLE_SCALE, no unreliable packets are dropped by 
		 * ENet, and so 100% of all unreliable packets will be sent.  When the throttle has a
		 * value of 0, all unreliable packets are dropped by ENet, and so 0% of all unreliable
		 * packets will be sent.  Intermediate values for the throttle represent intermediate
		 * probabilities between 0% and 100% of unreliable packets being sent.  The bandwidth
		 * limits of the local and foreign hosts are taken into account to determine a 
		 * sensible limit for the throttle probability above which it should not raise even in
		 * the best of conditions.
		 * @param peer peer to configure 
		 * @param interval interval, in milliseconds, over which to measure lowest mean RTT; the default value is ENET_PEER_PACKET_THROTTLE_INTERVAL.
		 * @param acceleration rate at which to increase the throttle probability as mean RTT declines
		 * @param deceleration rate at which to decrease the throttle probability as mean RTT increases
		 */
		public final function enet_peer_throttle_configure(peer : ENetPeer, interval : int, acceleration : int, deceleration : int) : void
		{
			var command : ENetProtocol = new ENetProtocol();
			peer.packetThrottleInterval = interval;
			peer.packetThrottleAcceleration = acceleration;
			peer.packetThrottleDeceleration = deceleration;
			command.header.command = 139;
			command.header.channelID = 255;
			command.throttleConfigure.packetThrottleInterval = this.p.eNET_HOST_TO_NET_32(interval);
			command.throttleConfigure.packetThrottleAcceleration = this.p.eNET_HOST_TO_NET_32(acceleration);
			command.throttleConfigure.packetThrottleDeceleration = this.p.eNET_HOST_TO_NET_32(deceleration);
			this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
		}

		/**
		 * Sets the timeout parameters for a peer.
		 * The timeout parameter control how and when a peer will timeout from a failure to acknowledge
		 * reliable traffic. Timeout values use an exponential backoff mechanism, where if a reliable
		 * packet is not acknowledge within some multiple of the average RTT plus a variance tolerance, 
		 * the timeout will be doubled until it reaches a set limit. If the timeout is thus at this
		 * limit and reliable packets have been sent but not acknowledged within a certain minimum time 
		 * period, the peer will be disconnected. Alternatively, if reliable packets have been sent
		 * but not acknowledged for a certain maximum time period, the peer will be disconnected regardless
		 * of the current timeout limit value.
		 * @param peer the peer to adjust
		 * @param timeoutLimit the timeout limit; defaults to ENET_PEER_TIMEOUT_LIMIT if 0
		 * @param timeoutMinimum the timeout minimum; defaults to ENET_PEER_TIMEOUT_MINIMUM if 0
		 * @param timeoutMaximum the timeout maximum; defaults to ENET_PEER_TIMEOUT_MAXIMUM if 0
		 */
		public final function enet_peer_timeout(peer : ENetPeer, timeoutLimit : int, timeoutMinimum : int, timeoutMaximum : int) : void
		{
			peer.timeoutLimit = timeoutLimit != 0 ? timeoutLimit : 32;
			peer.timeoutMinimum = timeoutMinimum != 0 ? timeoutMinimum : 5000;
			peer.timeoutMaximum = timeoutMaximum != 0 ? timeoutMaximum : 30000;
		}

		public final function enet_protocol_change_state(host : ENetHost, peer : ENetPeer, state : int) : void
		{
			if (state == 5 || state == 6)
				this.enet_peer_on_connect(peer);
			else
				this.enet_peer_on_disconnect(peer);
			peer.state = state;
		}

		public final function enet_protocol_check_timeouts(host : ENetHost, peer : ENetPeer, event_ : ENetEvent) : int
		{
			var outgoingCommand : ENetOutgoingCommand = null;
			var currentCommand : ENetListNode;
			var insertPosition : ENetListNode;
			currentCommand = this.enet_list_begin(peer.sentReliableCommands);
			insertPosition = this.enet_list_begin(peer.outgoingReliableCommands);
			while (currentCommand != this.enet_list_end(peer.sentReliableCommands)) {
				outgoingCommand = this.p.castToENetOutgoingCommand(currentCommand);
				currentCommand = this.enet_list_next(currentCommand);
				if (this.eNET_TIME_DIFFERENCE(host.serviceTime, outgoingCommand.sentTime) < outgoingCommand.roundTripTimeout)
					continue;
				if (peer.earliestTimeout == 0 || this.eNET_TIME_LESS(outgoingCommand.sentTime, peer.earliestTimeout))
					peer.earliestTimeout = outgoingCommand.sentTime;
				if (peer.earliestTimeout != 0 && (this.eNET_TIME_DIFFERENCE(host.serviceTime, peer.earliestTimeout) >= peer.timeoutMaximum || outgoingCommand.roundTripTimeout >= outgoingCommand.roundTripTimeoutLimit && this.eNET_TIME_DIFFERENCE(host.serviceTime, peer.earliestTimeout) >= peer.timeoutMinimum)) {
					this.enet_protocol_notify_disconnect(host, peer, event_);
					return 1;
				}
				if (outgoingCommand.packet != null)
					peer.reliableDataInTransit -= outgoingCommand.fragmentLength;
				peer.packetsLost++;
				outgoingCommand.roundTripTimeout *= 2;
				this.enet_list_insert(insertPosition, this.enet_list_remove(outgoingCommand.outgoingCommandList()));
				if (currentCommand == this.enet_list_begin(peer.sentReliableCommands) && !this.enet_list_empty(peer.sentReliableCommands)) {
					outgoingCommand = this.p.castToENetOutgoingCommand(currentCommand);
					peer.nextTimeout = outgoingCommand.sentTime + outgoingCommand.roundTripTimeout;
				}
			}
			return 0;
		}

		private function enet_protocol_command_size(commandNumber : int) : int
		{
			return this.commandSizes[commandNumber & 15];
		}

		public final function enet_protocol_dispatch_incoming_commands(host : ENetHost, event_ : ENetEvent) : int
		{
			while (!this.enet_list_empty(host.dispatchQueue)) {
				var peer : ENetPeer = this.p.castToENetPeer(this.enet_list_remove(this.enet_list_begin(host.dispatchQueue)));
				peer.needsDispatch = 0;
				switch (peer.state) {
				case 3:
				case 4:
					this.enet_protocol_change_state(host, peer, 5);
					event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T;
					event_.peer = peer;
					event_.data = peer.eventData;
					return 1;
				case 9:
					host.recalculateBandwidthLimits = 1;
					event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T;
					event_.peer = peer;
					event_.data = peer.eventData;
					this.enet_peer_reset(peer);
					return 1;
				case 5:
					if (this.enet_list_empty(peer.dispatchedCommands))
						continue;
					var b : Byte = new Byte();
					b.value = event_.channelID;
					event_.packet = this.enet_peer_receive(peer, b);
					event_.channelID = b.value;
					if (event_.packet == null)
						continue;
					event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E;
					event_.peer = peer;
					if (!this.enet_list_empty(peer.dispatchedCommands)) {
						peer.needsDispatch = 1;
						this.enet_list_insert(this.enet_list_end(host.dispatchQueue), peer.dispatchList());
					}
					return 1;
				default:
					break;
				}
			}
			return 0;
		}

		public final function enet_protocol_dispatch_state(host : ENetHost, peer : ENetPeer, state : int) : void
		{
			this.enet_protocol_change_state(host, peer, state);
			if (peer.needsDispatch == 0) {
				this.enet_list_insert(this.enet_list_end(host.dispatchQueue), peer.dispatchList());
				peer.needsDispatch = 1;
			}
		}

		public final function enet_protocol_handle_acknowledge(host : ENetHost, event_ : ENetEvent, peer : ENetPeer, command : ENetProtocol) : int
		{
			var roundTripTime : int;
			var receivedSentTime : int;
			var receivedReliableSequenceNumber : int;
			var commandNumber : int;
			if (peer.state == 0 || peer.state == 9)
				return 0;
			receivedSentTime = this.p.eNET_NET_TO_HOST_16(command.acknowledge.receivedSentTime);
			receivedSentTime |= host.serviceTime & -65536;
			if ((receivedSentTime & 32768) > (host.serviceTime & 32768))
				receivedSentTime -= 65536;
			if (this.eNET_TIME_LESS(host.serviceTime, receivedSentTime))
				return 0;
			peer.lastReceiveTime = host.serviceTime;
			peer.earliestTimeout = 0;
			roundTripTime = this.eNET_TIME_DIFFERENCE(host.serviceTime, receivedSentTime);
			this.enet_peer_throttle(peer, roundTripTime);
			peer.roundTripTimeVariance -= int(peer.roundTripTimeVariance / 4);
			if (roundTripTime >= peer.roundTripTime) {
				peer.roundTripTime += int((roundTripTime - peer.roundTripTime) / 8);
				peer.roundTripTimeVariance += int((roundTripTime - peer.roundTripTime) / 4);
			}
			else {
				peer.roundTripTime -= int((peer.roundTripTime - roundTripTime) / 8);
				peer.roundTripTimeVariance += int((peer.roundTripTime - roundTripTime) / 4);
			}
			if (peer.roundTripTime < peer.lowestRoundTripTime)
				peer.lowestRoundTripTime = peer.roundTripTime;
			if (peer.roundTripTimeVariance > peer.highestRoundTripTimeVariance)
				peer.highestRoundTripTimeVariance = peer.roundTripTimeVariance;
			if (peer.packetThrottleEpoch == 0 || this.eNET_TIME_DIFFERENCE(host.serviceTime, peer.packetThrottleEpoch) >= peer.packetThrottleInterval) {
				peer.lastRoundTripTime = peer.lowestRoundTripTime;
				peer.lastRoundTripTimeVariance = peer.highestRoundTripTimeVariance;
				peer.lowestRoundTripTime = peer.roundTripTime;
				peer.highestRoundTripTimeVariance = peer.roundTripTimeVariance;
				peer.packetThrottleEpoch = host.serviceTime;
			}
			receivedReliableSequenceNumber = this.p.eNET_NET_TO_HOST_16(command.acknowledge.receivedReliableSequenceNumber);
			commandNumber = this.enet_protocol_remove_sent_reliable_command(peer, this.p.intToUshort(receivedReliableSequenceNumber), command.header.channelID);
			switch (peer.state) {
			case 2:
				if (commandNumber != 3)
					return -1;
				this.enet_protocol_notify_connect(host, peer, event_);
				break;
			case 7:
				if (commandNumber != 4)
					return -1;
				this.enet_protocol_notify_disconnect(host, peer, event_);
				break;
			case 6:
				if (this.enet_list_empty(peer.outgoingReliableCommands) && this.enet_list_empty(peer.outgoingUnreliableCommands) && this.enet_list_empty(peer.sentReliableCommands))
					this.enet_peer_disconnect(peer, peer.eventData);
				break;
			default:
				break;
			}
			return 0;
		}

		public final function enet_protocol_handle_bandwidth_limit(host : ENetHost, peer : ENetPeer, command : ENetProtocol) : int
		{
			if (peer.state != 5 && peer.state != 6)
				return -1;
			if (peer.incomingBandwidth != 0)
				host.bandwidthLimitedPeers--;
			peer.incomingBandwidth = this.p.eNET_NET_TO_HOST_32(command.bandwidthLimit.incomingBandwidth);
			peer.outgoingBandwidth = this.p.eNET_NET_TO_HOST_32(command.bandwidthLimit.outgoingBandwidth);
			if (peer.incomingBandwidth != 0)
				host.bandwidthLimitedPeers++;
			if (peer.incomingBandwidth == 0 && host.outgoingBandwidth == 0)
				peer.windowSize = 32768;
			else
				peer.windowSize = int(this.eNET_MIN(peer.incomingBandwidth, host.outgoingBandwidth) / 65536) * 4096;
			if (peer.windowSize < 4096)
				peer.windowSize = 4096;
			else if (peer.windowSize > 32768)
				peer.windowSize = 32768;
			return 0;
		}

		public final function enet_protocol_handle_connect(host : ENetHost, header : ENetProtocolHeader, command : ENetProtocol) : ENetPeer
		{
			var incomingSessionID : int;
			var outgoingSessionID : int;
			var mtu : int;
			var windowSize : int;
			var channel : ENetChannel;
			var channelCount : int;
			var currentPeer : ENetPeer = new ENetPeer();
			var verifyCommand : ENetProtocol = new ENetProtocol();
			channelCount = this.p.eNET_NET_TO_HOST_32(command.connect.channelCount);
			if (channelCount < 1 || channelCount > 255)
				return null;
			var i : int;
			for (i = 0; i < host.peerCount; i++) {
				currentPeer = host.peers[i];
				if (currentPeer.state != 0 && currentPeer.address.host == host.receivedAddress.host && currentPeer.address.port == host.receivedAddress.port && currentPeer.connectID == command.connect.connectID)
					return null;
			}
			for (i = 0; i < host.peerCount; i++) {
				currentPeer = host.peers[i];
				if (currentPeer.state == 0)
					break;
			}
			if (i >= host.peerCount)
				return null;
			if (channelCount > host.channelLimit)
				channelCount = host.channelLimit;
			currentPeer.channels = new Array(channelCount);
			for (var k : int = 0; k < channelCount; k++) {
				currentPeer.channels[k] = new ENetChannel();
			}
			if (currentPeer.channels == null)
				return null;
			currentPeer.channelCount = channelCount;
			currentPeer.state = 2;
			currentPeer.connectID = command.connect.connectID;
			currentPeer.address = host.receivedAddress;
			currentPeer.outgoingPeerID = this.p.eNET_NET_TO_HOST_16(command.connect.outgoingPeerID);
			currentPeer.incomingBandwidth = this.p.eNET_NET_TO_HOST_32(command.connect.incomingBandwidth);
			currentPeer.outgoingBandwidth = this.p.eNET_NET_TO_HOST_32(command.connect.outgoingBandwidth);
			currentPeer.packetThrottleInterval = this.p.eNET_NET_TO_HOST_32(command.connect.packetThrottleInterval);
			currentPeer.packetThrottleAcceleration = this.p.eNET_NET_TO_HOST_32(command.connect.packetThrottleAcceleration);
			currentPeer.packetThrottleDeceleration = this.p.eNET_NET_TO_HOST_32(command.connect.packetThrottleDeceleration);
			currentPeer.eventData = this.p.eNET_NET_TO_HOST_32(command.connect.data);
			incomingSessionID = command.connect.incomingSessionID == 255 ? currentPeer.outgoingSessionID : command.connect.incomingSessionID;
			incomingSessionID = ENet.toByte(incomingSessionID + 1 & 3);
			if (incomingSessionID == currentPeer.outgoingSessionID)
				incomingSessionID = ENet.toByte(incomingSessionID + 1 & 3);
			currentPeer.outgoingSessionID = incomingSessionID;
			outgoingSessionID = command.connect.outgoingSessionID == 255 ? currentPeer.incomingSessionID : command.connect.outgoingSessionID;
			outgoingSessionID = ENet.toByte(outgoingSessionID + 1 & 3);
			if (outgoingSessionID == currentPeer.incomingSessionID)
				outgoingSessionID = ENet.toByte(outgoingSessionID + 1 & 3);
			currentPeer.incomingSessionID = outgoingSessionID;
			for (i = 0; i < currentPeer.channelCount; i++) {
				channel = currentPeer.channels[i];
				channel.outgoingReliableSequenceNumber = 0;
				channel.outgoingUnreliableSequenceNumber = 0;
				channel.incomingReliableSequenceNumber = 0;
				channel.incomingUnreliableSequenceNumber = 0;
				this.enet_list_clear(channel.incomingReliableCommands);
				this.enet_list_clear(channel.incomingUnreliableCommands);
				channel.usedReliableWindows = 0;
				for (var k : int = 0; k < 16; k++) {
					channel.reliableWindows[k] = 0;
				}
			}
			mtu = this.p.eNET_NET_TO_HOST_32(command.connect.mtu);
			if (mtu < 576)
				mtu = 576;
			else if (mtu > 4096)
				mtu = 4096;
			currentPeer.mtu = mtu;
			if (host.outgoingBandwidth == 0 && currentPeer.incomingBandwidth == 0)
				currentPeer.windowSize = 32768;
			else if (host.outgoingBandwidth == 0 || currentPeer.incomingBandwidth == 0)
				currentPeer.windowSize = int(this.eNET_MAX(host.outgoingBandwidth, currentPeer.incomingBandwidth) / 65536) * 4096;
			else
				currentPeer.windowSize = int(this.eNET_MIN(host.outgoingBandwidth, currentPeer.incomingBandwidth) / 65536) * 4096;
			if (currentPeer.windowSize < 4096)
				currentPeer.windowSize = 4096;
			else if (currentPeer.windowSize > 32768)
				currentPeer.windowSize = 32768;
			if (host.incomingBandwidth == 0)
				windowSize = 32768;
			else
				windowSize = int(host.incomingBandwidth / 65536) * 4096;
			if (windowSize > this.p.eNET_NET_TO_HOST_32(command.connect.windowSize))
				windowSize = this.p.eNET_NET_TO_HOST_32(command.connect.windowSize);
			if (windowSize < 4096)
				windowSize = 4096;
			else if (windowSize > 32768)
				windowSize = 32768;
			verifyCommand.header = new ENetProtocolCommandHeader();
			verifyCommand.header.command = 131;
			verifyCommand.header.channelID = 255;
			verifyCommand.verifyConnect = new ENetProtocolVerifyConnect();
			verifyCommand.verifyConnect.outgoingPeerID = this.p.eNET_HOST_TO_NET_16(currentPeer.incomingPeerID);
			verifyCommand.verifyConnect.incomingSessionID = incomingSessionID;
			verifyCommand.verifyConnect.outgoingSessionID = outgoingSessionID;
			verifyCommand.verifyConnect.mtu = this.p.eNET_HOST_TO_NET_32(currentPeer.mtu);
			verifyCommand.verifyConnect.windowSize = this.p.eNET_HOST_TO_NET_32(windowSize);
			verifyCommand.verifyConnect.channelCount = this.p.eNET_HOST_TO_NET_32(channelCount);
			verifyCommand.verifyConnect.incomingBandwidth = this.p.eNET_HOST_TO_NET_32(host.incomingBandwidth);
			verifyCommand.verifyConnect.outgoingBandwidth = this.p.eNET_HOST_TO_NET_32(host.outgoingBandwidth);
			verifyCommand.verifyConnect.packetThrottleInterval = this.p.eNET_HOST_TO_NET_32(currentPeer.packetThrottleInterval);
			verifyCommand.verifyConnect.packetThrottleAcceleration = this.p.eNET_HOST_TO_NET_32(currentPeer.packetThrottleAcceleration);
			verifyCommand.verifyConnect.packetThrottleDeceleration = this.p.eNET_HOST_TO_NET_32(currentPeer.packetThrottleDeceleration);
			verifyCommand.verifyConnect.connectID = currentPeer.connectID;
			this.enet_peer_queue_outgoing_command(currentPeer, verifyCommand, null, 0, 0);
			return currentPeer;
		}

		public final function enet_protocol_handle_disconnect(host : ENetHost, peer : ENetPeer, command : ENetProtocol) : int
		{
			if (peer.state == 0 || peer.state == 9 || peer.state == 8)
				return 0;
			this.enet_peer_reset_queues(peer);
			if (peer.state == 4 || peer.state == 7)
				this.enet_protocol_dispatch_state(host, peer, 9);
			else if (peer.state != 5 && peer.state != 6) {
				if (peer.state == 3)
					host.recalculateBandwidthLimits = 1;
				this.enet_peer_reset(peer);
			}
			else if ((command.header.command & 128) != 0)
				this.enet_protocol_change_state(host, peer, 8);
			else
				this.enet_protocol_dispatch_state(host, peer, 9);
			if (peer.state != 0)
				peer.eventData = this.p.eNET_NET_TO_HOST_32(command.disconnect.data);
			return 0;
		}

		public final function enet_protocol_handle_incoming_commands(host : ENetHost, event_ : ENetEvent) : int
		{
			var header : ENetProtocolHeader;
			var command : ENetProtocol = null;
			var peer : ENetPeer;
			var currentData : ByteArray = null;
			var headerSize : int = 0;
			var peerID : ushort;
			var flags : ushort;
			var sessionID : int;
			var currentDataI : Array = new Array(1);
			currentDataI[0] = 0;
			header = this.deserialize(host.receivedData);
			peerID = this.eNET_NET_TO_HOST_16(header.peerID);
			sessionID = (peerID & 12288) >> 12;
			flags = this.p.intToUshort(peerID & 49152);
			peerID &= this.p.intToUshort(~61440);
			headerSize = (flags & 32768) != 0 ? 4 : 2;
			if (host.checksum != null)
				headerSize += 4;
			if (peerID == 4095)
				peer = null;
			else if (peerID >= host.peerCount)
				return 0;
			else {
				peer = host.peers[peerID];
				if (peer.state == 0 || peer.state == 9 || (host.receivedAddress.host != peer.address.host || host.receivedAddress.port != peer.address.port) && peer.address.host != -1 || peer.outgoingPeerID < 4095 && sessionID != peer.incomingSessionID)
					return 0;
			}
			if ((flags & 16384) != 0) {
				var originalSize : int = 0;
				if (host.compressor == null)
					return 0;
				for (var i : int = 0; i < headerSize; i++) {
				}
				host.receivedData = host.packetData[1];
				host.receivedDataLength = headerSize + originalSize;
			}
			if (host.checksum != null) {
				var checksum : int = 0;
				var desiredChecksum : int = checksum;
				var buffer : ENetBuffer = new ENetBuffer();
				checksum = peer != null ? peer.connectID : 0;
				buffer.data = host.receivedData;
				buffer.dataLength = host.receivedDataLength;
				if (host.checksum.run(buffer, 1) != desiredChecksum)
					return 0;
			}
			if (peer != null) {
				peer.address.host = host.receivedAddress.host;
				peer.address.port = host.receivedAddress.port;
				peer.incomingDataTotal += host.receivedDataLength;
			}
			currentDataI[0] += headerSize;
			var test : int = 0;
			while (currentDataI[0] < host.receivedDataLength) {
				var commandNumber : int;
				var commandSize : int;
				if (test > 0) {
				}
				test++;
				if (currentDataI[0] + 4 > host.receivedDataLength)
					break;
				command = this.deserializeProtocolCommandHeader(host.receivedData, currentDataI[0]);
				commandNumber = ENet.toByte(command.header.command & 15);
				if (commandNumber == 0) {
				}
				if (commandNumber >= 13)
					break;
				commandSize = this.commandSizes[commandNumber];
				if (commandSize == 0 || currentDataI[0] + commandSize > host.receivedDataLength)
					break;
				this.deserializeProtocolCommandCommand(host.receivedData, currentDataI[0], commandNumber, command);
				currentDataI[0] += commandSize;
				if (peer == null && commandNumber != 2)
					break;
				command.header.reliableSequenceNumber = this.eNET_NET_TO_HOST_16(command.header.reliableSequenceNumber);
				if (this.test1 == 1) {
				}
				if (command.header.reliableSequenceNumber == 1) {
					this.test1++;
				}
				switch (commandNumber) {
				case 1:
					if (this.enet_protocol_handle_acknowledge(host, event_, peer, command) != 0)
						return this.commandError(event_);
					break;
				case 2:
					if (peer != null)
						return this.commandError(event_);
					peer = this.enet_protocol_handle_connect(host, header, command);
					if (peer == null)
						return this.commandError(event_);
					break;
				case 3:
					if (this.enet_protocol_handle_verify_connect(host, event_, peer, command) != 0)
						return this.commandError(event_);
					break;
				case 4:
					if (this.enet_protocol_handle_disconnect(host, peer, command) != 0)
						return this.commandError(event_);
					break;
				case 5:
					if (this.enet_protocol_handle_ping(host, peer, command) != 0)
						return this.commandError(event_);
					break;
				case 6:
					if (this.enet_protocol_handle_send_reliable(host, peer, command, host.receivedData, currentDataI) != 0)
						return this.commandError(event_);
					break;
				case 7:
					if (this.enet_protocol_handle_send_unreliable(host, peer, command, host.receivedData, currentDataI) != 0)
						return this.commandError(event_);
					break;
				case 9:
					if (this.enet_protocol_handle_send_unsequenced(host, peer, command, currentData) != 0)
						return this.commandError(event_);
					break;
				case 8:
					if (this.enet_protocol_handle_send_fragment(host, peer, command, host.receivedData, currentDataI) != 0)
						return this.commandError(event_);
					break;
				case 10:
					if (this.enet_protocol_handle_bandwidth_limit(host, peer, command) != 0)
						return this.commandError(event_);
					break;
				case 11:
					if (this.enet_protocol_handle_throttle_configure(host, peer, command) != 0)
						return this.commandError(event_);
					break;
				case 12:
					if (this.enet_protocol_handle_send_unreliable_fragment(host, peer, command, currentData) != 0)
						return this.commandError(event_);
					break;
				default:
					return this.commandError(event_);
				}
				if (peer != null && (command.header.command & 128) != 0) {
					var sentTime : ushort;
					if ((flags & 32768) == 0)
						break;
					sentTime = this.eNET_NET_TO_HOST_16(header.sentTime);
					switch (peer.state) {
					case 7:
					case 2:
					case 0:
					case 9:
						break;
					case 8:
						if ((command.header.command & 15) == 4)
							this.enet_peer_queue_acknowledgement(peer, command, sentTime);
						break;
					default:
						this.enet_peer_queue_acknowledgement(peer, command, sentTime);
						break;
					}
				}
			}
			if (event_ != null && event_.type != ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E) {
				return 1;
			}
			return 0;
		}

		public final function enet_protocol_handle_ping(host : ENetHost, peer : ENetPeer, command : ENetProtocol) : int
		{
			if (peer.state != 5 && peer.state != 6)
				return -1;
			return 0;
		}

		public final function enet_protocol_handle_send_fragment(host : ENetHost, peer : ENetPeer, command : ENetProtocol, currentData : ByteArray, currentDataI : Array) : int
		{
			var fragmentNumber : int;
			var fragmentCount : int;
			var fragmentOffset : int;
			var fragmentLength : int;
			var startSequenceNumber : int;
			var totalLength : int;
			var channel : ENetChannel;
			var startWindow : ushort;
			var currentWindow : ushort;
			var currentCommand : ENetListNode;
			var startCommand : ENetIncomingCommand = null;
			if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
				return -1;
			fragmentLength = this.p.eNET_NET_TO_HOST_16(command.sendFragment.dataLength);
			currentDataI[0] += fragmentLength;
			if (fragmentLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
				return -1;
			channel = peer.channels[command.header.channelID];
			startSequenceNumber = this.p.eNET_NET_TO_HOST_16(command.sendFragment.startSequenceNumber);
			startWindow = this.p.intToUshort(int(startSequenceNumber / 4096));
			currentWindow = this.p.intToUshort(int(channel.incomingReliableSequenceNumber / 4096));
			if (startSequenceNumber < channel.incomingReliableSequenceNumber)
				startWindow += 16;
			if (startWindow < currentWindow || startWindow >= currentWindow + 8 - 1)
				return 0;
			fragmentNumber = this.p.eNET_NET_TO_HOST_32(command.sendFragment.fragmentNumber);
			fragmentCount = this.p.eNET_NET_TO_HOST_32(command.sendFragment.fragmentCount);
			fragmentOffset = this.p.eNET_NET_TO_HOST_32(command.sendFragment.fragmentOffset);
			totalLength = this.p.eNET_NET_TO_HOST_32(command.sendFragment.totalLength);
			if (fragmentCount > 1048576 || fragmentNumber >= fragmentCount || totalLength > 1073741824 || fragmentOffset >= totalLength || fragmentLength > totalLength - fragmentOffset)
				return -1;
			for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingReliableCommands)); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
				var incomingCommand : ENetIncomingCommand = this.p.castToENetIncomingCommand(currentCommand);
				if (startSequenceNumber >= channel.incomingReliableSequenceNumber) {
					if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
						continue;
				}
				else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
					break;
				if (incomingCommand.reliableSequenceNumber <= startSequenceNumber) {
					if (incomingCommand.reliableSequenceNumber < startSequenceNumber)
						break;
					if ((incomingCommand.command.header.command & 15) != 8 || totalLength != incomingCommand.packet.dataLength || fragmentCount != incomingCommand.fragmentCount)
						return -1;
					startCommand = incomingCommand;
					break;
				}
			}
			if (startCommand == null) {
				var hostCommand : ENetProtocol = command;
				var packet : ENetPacket = this.enet_packet_create(null, totalLength, 1);
				if (packet == null)
					return -1;
				hostCommand.header.reliableSequenceNumber = this.p.intToUshort(startSequenceNumber);
				startCommand = this.enet_peer_queue_incoming_command(peer, hostCommand, packet, fragmentCount);
				if (startCommand == null)
					return -1;
			}
			if ((startCommand.fragments[int(fragmentNumber / 32)] & 1 << fragmentNumber % 32) == 0) {
				startCommand.fragmentsRemaining--;
				startCommand.fragments[int(fragmentNumber / 32)] |= 1 << fragmentNumber % 32;
				if (fragmentOffset + fragmentLength > startCommand.packet.dataLength)
					fragmentLength = startCommand.packet.dataLength - fragmentOffset;
				var data : ByteArray = new ByteArray();
				this.serializeCommand(data, command);
				for (var i : int = 0; i < fragmentLength; i++) {
					startCommand.packet.data[i + fragmentOffset] = data[i + 28];
				}
				if (startCommand.fragmentsRemaining <= 0)
					this.enet_peer_dispatch_incoming_reliable_commands(peer, channel);
			}
			return 0;
		}

		private function enet_protocol_handle_send_reliable(host : ENetHost, peer : ENetPeer, command : ENetProtocol, currentData : ByteArray, currentDataI : Array) : int
		{
			var packet : ENetPacket;
			var dataLength : int;
			if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
				return -1;
			dataLength = this.eNET_NET_TO_HOST_16(command.sendReliable.dataLength);
			if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
				return -1;
			command.data = new ByteArray();
			for (var i : int = 0; i < dataLength; i++) {
				command.data[i] = currentData[currentDataI[0] + i];
			}
			currentDataI[0] += dataLength;
			packet = this.enet_packet_create(command.data, dataLength, 1);
			if (packet == null || this.enet_peer_queue_incoming_command(peer, command, packet, 0) == null)
				return -1;
			return 0;
		}

		public final function enet_protocol_handle_send_unreliable(host : ENetHost, peer : ENetPeer, command : ENetProtocol, currentData : ByteArray, currentDataI : Array) : int
		{
			var packet : ENetPacket;
			var dataLength : int;
			if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
				return -1;
			dataLength = this.p.eNET_NET_TO_HOST_16(command.sendUnreliable.dataLength);
			currentDataI[0] += dataLength;
			if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
				return -1;
			command.data = new ByteArray();
			for (var i : int = 0; i < dataLength; i++) {
				command.data[i] = currentData[currentDataI[0] - dataLength + i];
			}
			packet = this.enet_packet_create(command.data, dataLength, 0);
			if (packet == null || this.enet_peer_queue_incoming_command(peer, command, packet, 0) == null)
				return -1;
			return 0;
		}

		public final function enet_protocol_handle_send_unreliable_fragment(host : ENetHost, peer : ENetPeer, command : ENetProtocol, currentData : ByteArray) : int
		{
			var fragmentNumber : int;
			var fragmentCount : int;
			var fragmentOffset : int;
			var fragmentLength : int;
			var reliableSequenceNumber : int;
			var startSequenceNumber : int;
			var totalLength : int;
			var reliableWindow : ushort;
			var currentWindow : ushort;
			var channel : ENetChannel;
			var currentCommand : ENetListNode;
			var startCommand : ENetIncomingCommand = null;
			if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
				return -1;
			fragmentLength = this.eNET_NET_TO_HOST_16(command.sendFragment.dataLength);
			var currentDataI : int = 0;
			currentDataI += fragmentLength;
			if (fragmentLength > 1073741824 || currentDataI < 0 || currentDataI > host.receivedDataLength)
				return -1;
			channel = peer.channels[command.header.channelID];
			reliableSequenceNumber = command.header.reliableSequenceNumber;
			startSequenceNumber = this.eNET_NET_TO_HOST_16(command.sendFragment.startSequenceNumber);
			reliableWindow = this.p.intToUshort(int(reliableSequenceNumber / 4096));
			currentWindow = this.p.intToUshort(int(channel.incomingReliableSequenceNumber / 4096));
			if (reliableSequenceNumber < channel.incomingReliableSequenceNumber)
				reliableWindow += 16;
			if (reliableWindow < currentWindow || reliableWindow >= currentWindow + 8 - 1)
				return 0;
			if (reliableSequenceNumber == channel.incomingReliableSequenceNumber && startSequenceNumber <= channel.incomingUnreliableSequenceNumber)
				return 0;
			fragmentNumber = this.eNET_NET_TO_HOST_32(command.sendFragment.fragmentNumber);
			fragmentCount = this.eNET_NET_TO_HOST_32(command.sendFragment.fragmentCount);
			fragmentOffset = this.eNET_NET_TO_HOST_32(command.sendFragment.fragmentOffset);
			totalLength = this.eNET_NET_TO_HOST_32(command.sendFragment.totalLength);
			if (fragmentCount > 1048576 || fragmentNumber >= fragmentCount || totalLength > 1073741824 || fragmentOffset >= totalLength || fragmentLength > totalLength - fragmentOffset)
				return -1;
			for (currentCommand = this.enet_list_previous(this.enet_list_end(channel.incomingUnreliableCommands)); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_previous(currentCommand)) {
				var incomingCommand : ENetIncomingCommand = this.p.castToENetIncomingCommand(currentCommand);
				if (reliableSequenceNumber >= channel.incomingReliableSequenceNumber) {
					if (incomingCommand.reliableSequenceNumber < channel.incomingReliableSequenceNumber)
						continue;
				}
				else if (incomingCommand.reliableSequenceNumber >= channel.incomingReliableSequenceNumber)
					break;
				if (incomingCommand.reliableSequenceNumber < reliableSequenceNumber)
					break;
				if (incomingCommand.reliableSequenceNumber > reliableSequenceNumber)
					continue;
				if (incomingCommand.unreliableSequenceNumber <= startSequenceNumber) {
					if (incomingCommand.unreliableSequenceNumber < startSequenceNumber)
						break;
					if ((incomingCommand.command.header.command & 15) != 12 || totalLength != incomingCommand.packet.dataLength || fragmentCount != incomingCommand.fragmentCount)
						return -1;
					startCommand = incomingCommand;
					break;
				}
			}
			if (startCommand == null) {
				var packet : ENetPacket = this.enet_packet_create(null, totalLength, 8);
				if (packet == null)
					return -1;
				startCommand = this.enet_peer_queue_incoming_command(peer, command, packet, fragmentCount);
				if (startCommand == null)
					return -1;
			}
			if ((startCommand.fragments[int(fragmentNumber / 32)] & 1 << fragmentNumber % 32) == 0) {
				startCommand.fragmentsRemaining--;
				startCommand.fragments[int(fragmentNumber / 32)] |= 1 << fragmentNumber % 32;
				if (fragmentOffset + fragmentLength > startCommand.packet.dataLength)
					fragmentLength = startCommand.packet.dataLength - fragmentOffset;
				for (var i : int = 0; i < fragmentLength; i++) {
					startCommand.packet.data[fragmentOffset + i] = command.data[i];
				}
				if (startCommand.fragmentsRemaining <= 0)
					this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
			}
			return 0;
		}

		public final function enet_protocol_handle_send_unsequenced(host : ENetHost, peer : ENetPeer, command : ENetProtocol, currentData : ByteArray) : int
		{
			return 0;
		}

		public final function enet_protocol_handle_throttle_configure(host : ENetHost, peer : ENetPeer, command : ENetProtocol) : int
		{
			if (peer.state != 5 && peer.state != 6)
				return -1;
			peer.packetThrottleInterval = this.p.eNET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleInterval);
			peer.packetThrottleAcceleration = this.p.eNET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleAcceleration);
			peer.packetThrottleDeceleration = this.p.eNET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleDeceleration);
			return 0;
		}

		public final function enet_protocol_handle_verify_connect(host : ENetHost, event_ : ENetEvent, peer : ENetPeer, command : ENetProtocol) : int
		{
			var mtu : int;
			var windowSize : int;
			var channelCount : int;
			if (peer.state != 1)
				return 0;
			channelCount = this.p.eNET_NET_TO_HOST_32(command.verifyConnect.channelCount);
			if (channelCount < 1 || channelCount > 255 || this.p.eNET_NET_TO_HOST_32(command.verifyConnect.packetThrottleInterval) != peer.packetThrottleInterval || this.p.eNET_NET_TO_HOST_32(command.verifyConnect.packetThrottleAcceleration) != peer.packetThrottleAcceleration || this.p.eNET_NET_TO_HOST_32(command.verifyConnect.packetThrottleDeceleration) != peer.packetThrottleDeceleration || command.verifyConnect.connectID != peer.connectID) {
				peer.eventData = 0;
				this.enet_protocol_dispatch_state(host, peer, 9);
				return -1;
			}
			this.enet_protocol_remove_sent_reliable_command(peer, 1, 255);
			if (channelCount < peer.channelCount)
				peer.channelCount = channelCount;
			peer.outgoingPeerID = this.p.eNET_NET_TO_HOST_16(command.verifyConnect.outgoingPeerID);
			peer.incomingSessionID = command.verifyConnect.incomingSessionID;
			peer.outgoingSessionID = command.verifyConnect.outgoingSessionID;
			mtu = this.p.eNET_NET_TO_HOST_32(command.verifyConnect.mtu);
			if (mtu < 576)
				mtu = 576;
			else if (mtu > 4096)
				mtu = 4096;
			if (mtu < peer.mtu)
				peer.mtu = mtu;
			windowSize = this.p.eNET_NET_TO_HOST_32(command.verifyConnect.windowSize);
			if (windowSize < 4096)
				windowSize = 4096;
			if (windowSize > 32768)
				windowSize = 32768;
			if (windowSize < peer.windowSize)
				peer.windowSize = windowSize;
			peer.incomingBandwidth = this.p.eNET_NET_TO_HOST_32(command.verifyConnect.incomingBandwidth);
			peer.outgoingBandwidth = this.p.eNET_NET_TO_HOST_32(command.verifyConnect.outgoingBandwidth);
			this.enet_protocol_notify_connect(host, peer, event_);
			return 0;
		}

		public final function enet_protocol_notify_connect(host : ENetHost, peer : ENetPeer, event_ : ENetEvent) : void
		{
			host.recalculateBandwidthLimits = 1;
			if (event_ != null) {
				this.enet_protocol_change_state(host, peer, 5);
				event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T;
				event_.peer = peer;
				event_.data = peer.eventData;
			}
			else
				this.enet_protocol_dispatch_state(host, peer, peer.state == 1 ? 4 : 3);
		}

		public final function enet_protocol_notify_disconnect(host : ENetHost, peer : ENetPeer, event_ : ENetEvent) : void
		{
			if (peer.state >= 3)
				host.recalculateBandwidthLimits = 1;
			if (peer.state != 1 && peer.state < 4)
				this.enet_peer_reset(peer);
			else if (event_ != null) {
				event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T;
				event_.peer = peer;
				event_.data = 0;
				this.enet_peer_reset(peer);
			}
			else {
				peer.eventData = 0;
				this.enet_protocol_dispatch_state(host, peer, 9);
			}
		}

		public final function enet_protocol_receive_incoming_commands(host : ENetHost, event_ : ENetEvent) : int
		{
			for (;;) {
				var receivedLength : int;
				var buffer : ENetBuffer = new ENetBuffer();
				buffer.data = host.packetData[0];
				buffer.dataLength = 4096;
				var buffers : Array = new Array(1);
				buffers[0] = buffer;
				receivedLength = this.p.enet_socket_receive(host.socket, host.receivedAddress, buffers, 1);
				if (receivedLength < 0)
					return -1;
				if (receivedLength == 0)
					return 0;
				host.receivedData = host.packetData[0];
				host.receivedDataLength = receivedLength;
				host.totalReceivedData += receivedLength;
				host.totalReceivedPackets++;
				if (host.intercept != null) {
					switch (host.intercept.run(host, event_)) {
					case 1:
						if (event_ != null && event_.type != ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
							return 1;
						continue;
					case -1:
						return -1;
					default:
						break;
					}
				}
				switch (this.enet_protocol_handle_incoming_commands(host, event_)) {
				case 1:
					return 1;
				case -1:
					return -1;
				default:
					break;
				}
			}
			throw "Unreachable";
		}

		public final function enet_protocol_remove_sent_reliable_command(peer : ENetPeer, reliableSequenceNumber : ushort, channelID : int) : int
		{
			var outgoingCommand : ENetOutgoingCommand = null;
			var currentCommand : ENetListNode;
			var commandNumber : int;
			var wasSent : int = 1;
			for (currentCommand = this.enet_list_begin(peer.sentReliableCommands); currentCommand != this.enet_list_end(peer.sentReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
				outgoingCommand = this.p.castToENetOutgoingCommand(currentCommand);
				if (outgoingCommand.reliableSequenceNumber == reliableSequenceNumber && outgoingCommand.command.header.channelID == channelID)
					break;
			}
			if (currentCommand == this.enet_list_end(peer.sentReliableCommands)) {
				for (currentCommand = this.enet_list_begin(peer.outgoingReliableCommands); currentCommand != this.enet_list_end(peer.outgoingReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
					outgoingCommand = this.p.castToENetOutgoingCommand(currentCommand);
					if (outgoingCommand.sendAttempts < 1)
						return 0;
					if (outgoingCommand.reliableSequenceNumber == reliableSequenceNumber && outgoingCommand.command.header.channelID == channelID)
						break;
				}
				if (currentCommand == this.enet_list_end(peer.outgoingReliableCommands))
					return 0;
				wasSent = 0;
			}
			if (outgoingCommand == null)
				return 0;
			if (channelID < peer.channelCount) {
				var channel : ENetChannel = peer.channels[channelID];
				var reliableWindow : ushort = this.p.intToUshort(int(reliableSequenceNumber / 4096));
				if (channel.reliableWindows[reliableWindow] > 0) {
					channel.reliableWindows[reliableWindow]--;
					if (channel.reliableWindows[reliableWindow] == 0)
						channel.usedReliableWindows &= ~(1 << reliableWindow);
				}
			}
			commandNumber = outgoingCommand.command.header.command & 15;
			this.enet_list_remove(outgoingCommand.outgoingCommandList());
			if (outgoingCommand.packet != null) {
				if (wasSent != 0)
					peer.reliableDataInTransit -= outgoingCommand.fragmentLength;
				outgoingCommand.packet.referenceCount--;
				if (outgoingCommand.packet.referenceCount == 0) {
					outgoingCommand.packet.flags |= 256;
					this.enet_packet_destroy(outgoingCommand.packet);
				}
			}
			if (this.enet_list_empty(peer.sentReliableCommands))
				return commandNumber;
			outgoingCommand = this.p.castToENetOutgoingCommand(this.enet_list_front(peer.sentReliableCommands));
			peer.nextTimeout = outgoingCommand.sentTime + outgoingCommand.roundTripTimeout;
			return commandNumber;
		}

		public final function enet_protocol_remove_sent_unreliable_commands(peer : ENetPeer) : void
		{
			var outgoingCommand : ENetOutgoingCommand;
			while (!this.enet_list_empty(peer.sentUnreliableCommands)) {
				outgoingCommand = this.p.castToENetOutgoingCommand(this.enet_list_front(peer.sentUnreliableCommands));
				this.enet_list_remove(outgoingCommand.outgoingCommandList());
				if (outgoingCommand.packet != null) {
					outgoingCommand.packet.referenceCount--;
					if (outgoingCommand.packet.referenceCount == 0) {
						outgoingCommand.packet.flags |= 256;
						this.enet_packet_destroy(outgoingCommand.packet);
					}
				}
			}
		}

		private function enet_protocol_send_acknowledgements(host : ENetHost, peer : ENetPeer) : void
		{
			var commandI : int = host.commandCount;
			var bufferI : int = host.bufferCount;
			var acknowledgement : ENetAcknowledgement;
			var currentAcknowledgement : ENetListNode;
			var reliableSequenceNumber : ushort;
			currentAcknowledgement = this.enet_list_begin(peer.acknowledgements);
			while (currentAcknowledgement != this.enet_list_end(peer.acknowledgements)) {
				if (commandI >= 32 || bufferI >= 65 || peer.mtu - host.packetSize < 8) {
					host.continueSending = 1;
					break;
				}
				acknowledgement = this.p.castToENetAcknowledgement(currentAcknowledgement);
				currentAcknowledgement = this.enet_list_next(currentAcknowledgement);
				if (this.test1 == 1) {
				}
				reliableSequenceNumber = this.eNET_HOST_TO_NET_16(acknowledgement.command.header.reliableSequenceNumber);
				host.commands[commandI].header.command = 1;
				host.commands[commandI].header.channelID = acknowledgement.command.header.channelID;
				host.commands[commandI].header.reliableSequenceNumber = reliableSequenceNumber;
				host.commands[commandI].acknowledge = new ENetProtocolAcknowledge();
				host.commands[commandI].acknowledge.receivedReliableSequenceNumber = reliableSequenceNumber;
				host.commands[commandI].acknowledge.receivedSentTime = this.eNET_HOST_TO_NET_16(this.p.intToUshort(acknowledgement.sentTime));
				var buf : ByteArray = new ByteArray();
				this.serializeCommand(buf, host.commands[commandI]);
				host.buffers[bufferI].data = buf;
				host.buffers[bufferI].dataLength = 8;
				host.packetSize += host.buffers[bufferI].dataLength;
				if ((acknowledgement.command.header.command & 15) == 4)
					this.enet_protocol_dispatch_state(host, peer, 9);
				this.enet_list_remove(acknowledgement.acknowledgementList());
				commandI++;
				bufferI++;
			}
			host.commandCount = commandI;
			host.bufferCount = bufferI;
		}

		public final function enet_protocol_send_outgoing_commands(host : ENetHost, event_ : ENetEvent, checkForTimeouts : int) : int
		{
			var headerData : ByteArray = new ByteArray();
			var header : ENetProtocolHeader = new ENetProtocolHeader();
			var currentPeer : ENetPeer;
			var sentLength : int;
			var shouldCompress : int = 0;
			host.continueSending = 1;
			while (host.continueSending != 0) {
				host.continueSending = 0;
				for (var i : int = 0; i < host.peerCount; i++) {
					if (this.test1 == 1) {
					}
					currentPeer = host.peers[i];
					if (currentPeer.state == 0 || currentPeer.state == 9)
						continue;
					host.headerFlags = 0;
					host.commandCount = 0;
					host.bufferCount = 1;
					host.packetSize = 4;
					if (!this.enet_list_empty(currentPeer.acknowledgements))
						this.enet_protocol_send_acknowledgements(host, currentPeer);
					if (checkForTimeouts != 0 && !this.enet_list_empty(currentPeer.sentReliableCommands) && this.eNET_TIME_GREATER_EQUAL(host.serviceTime, currentPeer.nextTimeout) && this.enet_protocol_check_timeouts(host, currentPeer, event_) == 1) {
						if (event_ != null && event_.type != ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
							return 1;
						else
							continue;
					}
					if ((this.enet_list_empty(currentPeer.outgoingReliableCommands) || this.enet_protocol_send_reliable_outgoing_commands(host, currentPeer) != 0) && this.enet_list_empty(currentPeer.sentReliableCommands) && this.eNET_TIME_DIFFERENCE(host.serviceTime, currentPeer.lastReceiveTime) >= currentPeer.pingInterval && currentPeer.mtu - host.packetSize >= 4) {
						this.enet_peer_ping(currentPeer);
						this.enet_protocol_send_reliable_outgoing_commands(host, currentPeer);
					}
					if (!this.enet_list_empty(currentPeer.outgoingUnreliableCommands))
						this.enet_protocol_send_unreliable_outgoing_commands(host, currentPeer);
					if (host.commandCount == 0)
						continue;
					if (currentPeer.packetLossEpoch == 0)
						currentPeer.packetLossEpoch = host.serviceTime;
					else if (this.eNET_TIME_DIFFERENCE(host.serviceTime, currentPeer.packetLossEpoch) >= 10000 && currentPeer.packetsSent > 0) {
						var packetLoss : int = int(currentPeer.packetsLost * 65536 / currentPeer.packetsSent);
						currentPeer.packetLossVariance -= int(currentPeer.packetLossVariance / 4);
						if (packetLoss >= currentPeer.packetLoss) {
							currentPeer.packetLoss += int((packetLoss - currentPeer.packetLoss) / 8);
							currentPeer.packetLossVariance += int((packetLoss - currentPeer.packetLoss) / 4);
						}
						else {
							currentPeer.packetLoss -= int((currentPeer.packetLoss - packetLoss) / 8);
							currentPeer.packetLossVariance += int((currentPeer.packetLoss - packetLoss) / 4);
						}
						currentPeer.packetLossEpoch = host.serviceTime;
						currentPeer.packetsSent = 0;
						currentPeer.packetsLost = 0;
					}
					host.buffers[0].data = headerData;
					if ((host.headerFlags & 32768) != 0) {
						header.sentTime = this.eNET_HOST_TO_NET_16(this.p.intToUshort(host.serviceTime & 65535));
						host.buffers[0].dataLength = 4;
					}
					else {
						host.buffers[0].dataLength = 2;
					}
					shouldCompress = 0;
					if (host.compressor != null) {
					}
					if (currentPeer.outgoingPeerID < 4095)
						host.headerFlags |= this.p.intToUshort(currentPeer.outgoingSessionID << 12);
					header.peerID = this.eNET_HOST_TO_NET_16(this.p.intToUshort(currentPeer.outgoingPeerID | host.headerFlags));
					this.serializeHeader(headerData, header);
					if (host.checksum != null) {
					}
					if (shouldCompress > 0) {
						host.buffers[1].data = host.packetData[1];
						host.buffers[1].dataLength = shouldCompress;
						host.bufferCount = 2;
					}
					currentPeer.lastSendTime = host.serviceTime;
					sentLength = this.p.enet_socket_send(host.socket, currentPeer.address, host.buffers, host.bufferCount);
					this.enet_protocol_remove_sent_unreliable_commands(currentPeer);
					if (sentLength < 0)
						return -1;
					host.totalSentData += sentLength;
					host.totalSentPackets++;
				}
			}
			return 0;
		}

		public final function enet_protocol_send_reliable_outgoing_commands(host : ENetHost, peer : ENetPeer) : int
		{
			var commandI : int = host.commandCount;
			var bufferI : int = host.bufferCount;
			var outgoingCommand : ENetOutgoingCommand;
			var currentCommand : ENetListNode;
			var channel : ENetChannel;
			var reliableWindow : ushort;
			var commandSize : int;
			var windowExceeded : int = 0;
			var windowWrap : int = 0;
			var canPing : int = 1;
			currentCommand = this.enet_list_begin(peer.outgoingReliableCommands);
			if (this.test1 == 1) {
				this.test1 = this.test1;
			}
			while (currentCommand != this.enet_list_end(peer.outgoingReliableCommands)) {
				outgoingCommand = this.p.castToENetOutgoingCommand(currentCommand);
				channel = outgoingCommand.command.header.channelID < peer.channelCount ? peer.channels[outgoingCommand.command.header.channelID] : null;
				reliableWindow = this.p.intToUshort(int(outgoingCommand.reliableSequenceNumber / 4096));
				if (channel != null) {
					if (windowWrap == 0 && outgoingCommand.sendAttempts < 1 && outgoingCommand.reliableSequenceNumber % 4096 == 0 && (channel.reliableWindows[(reliableWindow + 16 - 1) % 16] >= 4096 || (channel.usedReliableWindows & (255 << reliableWindow | 255 >> 4096 - reliableWindow)) != 0))
						windowWrap = 1;
					if (windowWrap != 0) {
						currentCommand = this.enet_list_next(currentCommand);
						continue;
					}
				}
				if (outgoingCommand.packet != null) {
					if (windowExceeded == 0) {
						var windowSize : int = int(peer.packetThrottle * peer.windowSize / 32);
						if (peer.reliableDataInTransit + outgoingCommand.fragmentLength > this.eNET_MAX(windowSize, peer.mtu))
							windowExceeded = 1;
					}
					if (windowExceeded != 0) {
						currentCommand = this.enet_list_next(currentCommand);
						continue;
					}
				}
				canPing = 0;
				commandSize = this.commandSizes[outgoingCommand.command.header.command & 15];
				if (commandI > host.commandCount || bufferI > host.bufferCount || peer.mtu - host.packetSize < commandSize || outgoingCommand.packet != null && this.toUint16(peer.mtu - host.packetSize) < this.toUint16(commandSize + outgoingCommand.fragmentLength)) {
					host.continueSending = 1;
					break;
				}
				currentCommand = this.enet_list_next(currentCommand);
				if (channel != null && outgoingCommand.sendAttempts < 1) {
					channel.usedReliableWindows |= 1 << reliableWindow;
					channel.reliableWindows[reliableWindow]++;
				}
				outgoingCommand.sendAttempts++;
				if (outgoingCommand.roundTripTimeout == 0) {
					outgoingCommand.roundTripTimeout = peer.roundTripTime + 4 * peer.roundTripTimeVariance;
					outgoingCommand.roundTripTimeoutLimit = peer.timeoutLimit * outgoingCommand.roundTripTimeout;
				}
				if (this.enet_list_empty(peer.sentReliableCommands))
					peer.nextTimeout = host.serviceTime + outgoingCommand.roundTripTimeout;
				this.enet_list_insert(this.enet_list_end(peer.sentReliableCommands), this.enet_list_remove(outgoingCommand.outgoingCommandList()));
				outgoingCommand.sentTime = host.serviceTime;
				var command : ENetProtocol = outgoingCommand.command;
				host.commands[commandI] = command;
				host.buffers[bufferI].data = new ByteArray();
				this.serializeCommand(host.buffers[bufferI].data, host.commands[commandI]);
				host.buffers[bufferI].dataLength = commandSize;
				host.packetSize += host.buffers[bufferI].dataLength;
				host.headerFlags |= 32768;
				if (outgoingCommand.packet != null) {
					bufferI++;
					var data : ByteArray = new ByteArray();
					for (var i : int = 0; i < outgoingCommand.packet.dataLength - outgoingCommand.fragmentOffset; i++) {
						data[i] = outgoingCommand.packet.data[i + outgoingCommand.fragmentOffset];
					}
					host.buffers[bufferI].data = data;
					host.buffers[bufferI].dataLength = outgoingCommand.fragmentLength;
					host.packetSize += outgoingCommand.fragmentLength;
					peer.reliableDataInTransit += outgoingCommand.fragmentLength;
				}
				peer.packetsSent++;
				commandI++;
				bufferI++;
			}
			host.commandCount = commandI;
			host.bufferCount = bufferI;
			return canPing;
		}

		public final function enet_protocol_send_unreliable_outgoing_commands(host : ENetHost, peer : ENetPeer) : void
		{
		}

		private function freePacket(fragmentCount : int, packet : ENetPacket) : ENetIncomingCommand
		{
			if (fragmentCount > 0)
				return this.notifyError(packet);
			if (packet != null && packet.referenceCount == 0)
				this.enet_packet_destroy(packet);
			return this.dummyCommand;
		}

		private function initialize_crc32() : void
		{
			this.crcTable = new Array(256);
			var byte_ : int;
			var c : int = -2147483647;
			c -= 1;
			for (byte_ = 0; byte_ < 256; byte_++) {
				var crc : int = ENet.reflect_crc(byte_, 8) << 24;
				var offset : int;
				for (offset = 0; offset < 8; offset++) {
					if ((crc & c) != 0)
						crc = crc << 1 ^ 79764919;
					else
						crc <<= 1;
				}
				this.crcTable[byte_] = ENet.reflect_crc(crc, 32);
			}
			this.initializedCRC32 = true;
		}
		private var initializedCRC32 : Boolean;

		private function memcpy(destination : ByteArray, source : ByteArray, num : int) : void
		{
			for (var i : int = 0; i < num; i++) {
				destination[i] = source[i];
			}
		}

		private function notifyError(packet : ENetPacket) : ENetIncomingCommand
		{
			if (packet != null && packet.referenceCount == 0)
				this.enet_packet_destroy(packet);
			return null;
		}
		private var p : ENetPlatform;

		private static function reflect_crc(val : int, bits : int) : int
		{
			var result : int = 0;
			var bit : int;
			for (bit = 0; bit < bits; bit++) {
				if ((val & 1) != 0)
					result |= 1 << bits - 1 - bit;
				val >>= 1;
			}
			return result;
		}
		private var test1 : int;
	}
}
