// Generated automatically with "cito". Do not edit.

function Byte()
{
	this.value = 0;
}

function ENet()
{
	this.commandSizes = null;
	this.crcTable = null;
	this.dummyCommand = null;
	this.initializedCRC32 = false;
	this.p = null;
	this.test1 = 0;
	this.dummyCommand = new ENetIncomingCommand();
	this.commandSizes = new Int32Array(new ArrayBuffer(13 << 2));
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

ENet.prototype.deserialize = function(a) {
	var h = new ENetProtocolHeader();
	h.peerID = this.readShort(a, 0);
	h.sentTime = this.readShort(a, 2);
	return h;
}

ENet.prototype.deserializeProtocolCommandCommand = function(readBuf, currentDataI, commandNumber, command) {
	var pos = currentDataI + 4;
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

ENet.prototype.deserializeProtocolCommandHeader = function(currentData, currentDataI) {
	var pos = currentDataI;
	var a = new ENetProtocol();
	a.header = new ENetProtocolCommandHeader();
	a.header.command = this.readByte(currentData, pos);
	pos += 1;
	a.header.channelID = this.readByte(currentData, pos);
	pos += 1;
	a.header.reliableSequenceNumber = this.readShort(currentData, pos);
	pos += 2;
	return a;
}
ENet.E_N_E_T__B_U_F_F_E_R__M_A_X_I_M_U_M = 65;
ENet.E_N_E_T__H_O_S_T__A_N_Y = 0;
ENet.E_N_E_T__H_O_S_T__B_A_N_D_W_I_D_T_H__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L = 1000;
ENet.E_N_E_T__H_O_S_T__B_R_O_A_D_C_A_S_T = -1;
ENet.E_N_E_T__H_O_S_T__D_E_F_A_U_L_T__M_T_U = 1400;
ENet.E_N_E_T__H_O_S_T__R_E_C_E_I_V_E__B_U_F_F_E_R__S_I_Z_E = 262144;
ENet.E_N_E_T__H_O_S_T__S_E_N_D__B_U_F_F_E_R__S_I_Z_E = 262144;

ENet.prototype.eNET_HOST_TO_NET_16 = function(a) {
	return this.p.eNET_HOST_TO_NET_16(a);
}

ENet.prototype.eNET_HOST_TO_NET_32 = function(a) {
	return this.p.eNET_HOST_TO_NET_32(a);
}

ENet.prototype.eNET_MAX = function(x, y) {
	return x > y ? x : y;
}

ENet.prototype.eNET_MIN = function(x, y) {
	return x < y ? x : y;
}

ENet.prototype.eNET_NET_TO_HOST_16 = function(a) {
	return this.p.eNET_NET_TO_HOST_16(a);
}

ENet.prototype.eNET_NET_TO_HOST_32 = function(a) {
	return this.p.eNET_NET_TO_HOST_32(a);
}
ENet.E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__P_A_C_K_E_T__T_H_R_O_T_T_L_E = 32;
ENet.E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__R_O_U_N_D__T_R_I_P__T_I_M_E = 500;
ENet.E_N_E_T__P_E_E_R__F_R_E_E__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S = 8;
ENet.E_N_E_T__P_E_E_R__F_R_E_E__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S = 32;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__I_N_T_E_R_V_A_L = 10000;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__S_C_A_L_E = 65536;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__A_C_C_E_L_E_R_A_T_I_O_N = 2;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__C_O_U_N_T_E_R = 7;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__D_E_C_E_L_E_R_A_T_I_O_N = 2;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L = 5000;
ENet.E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__S_C_A_L_E = 32;
ENet.E_N_E_T__P_E_E_R__P_I_N_G__I_N_T_E_R_V_A_L = 500;
ENet.E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S = 16;
ENet.E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W__S_I_Z_E = 4096;
ENet.E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__L_I_M_I_T = 32;
ENet.E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_A_X_I_M_U_M = 30000;
ENet.E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_I_N_I_M_U_M = 5000;
ENet.E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S = 64;
ENet.E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W__S_I_Z_E = 1024;
ENet.E_N_E_T__P_E_E_R__W_I_N_D_O_W__S_I_Z_E__S_C_A_L_E = 65536;
ENet.E_N_E_T__P_O_R_T__A_N_Y = 0;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__A_C_K_N_O_W_L_E_D_G_E = 1;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__B_A_N_D_W_I_D_T_H__L_I_M_I_T = 10;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_N_N_E_C_T = 2;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_U_N_T = 13;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__D_I_S_C_O_N_N_E_C_T = 4;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__A_C_K_N_O_W_L_E_D_G_E = 128;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D = 64;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__M_A_S_K = 15;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__N_O_N_E = 0;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__P_I_N_G = 5;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__F_R_A_G_M_E_N_T = 8;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__R_E_L_I_A_B_L_E = 6;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E = 7;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T = 12;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_S_E_Q_U_E_N_C_E_D = 9;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__T_H_R_O_T_T_L_E__C_O_N_F_I_G_U_R_E = 11;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__V_E_R_I_F_Y__C_O_N_N_E_C_T = 3;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__C_O_M_P_R_E_S_S_E_D = 16384;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__M_A_S_K = 49152;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__S_E_N_T__T_I_M_E = 32768;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__M_A_S_K = 12288;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__S_H_I_F_T = 12;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T = 255;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__F_R_A_G_M_E_N_T__C_O_U_N_T = 1048576;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__M_T_U = 4096;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__C_O_M_M_A_N_D_S = 32;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__S_I_Z_E = 1073741824;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_E_E_R__I_D = 4095;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__W_I_N_D_O_W__S_I_Z_E = 32768;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T = 1;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__M_T_U = 576;
ENet.E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__W_I_N_D_O_W__S_I_Z_E = 4096;
ENet.E_N_E_T__S_O_C_K_E_T__W_A_I_T__I_N_T_E_R_R_U_P_T = 4;
ENet.E_N_E_T__S_O_C_K_E_T__W_A_I_T__N_O_N_E = 0;
ENet.E_N_E_T__S_O_C_K_E_T__W_A_I_T__R_E_C_E_I_V_E = 2;
ENet.E_N_E_T__S_O_C_K_E_T__W_A_I_T__S_E_N_D = 1;

ENet.prototype.eNET_TIME_DIFFERENCE = function(a, b) {
	return a - b < 0 ? b - a : a - b;
}

ENet.prototype.eNET_TIME_GREATER = function(a, b) {
	return b - a < 0;
}

ENet.prototype.eNET_TIME_GREATER_EQUAL = function(a, b) {
	return !this.eNET_TIME_LESS(a, b);
}

ENet.prototype.eNET_TIME_LESS = function(a, b) {
	return a - b < 0;
}

ENet.prototype.eNET_TIME_LESS_EQUAL = function(a, b) {
	return !this.eNET_TIME_GREATER(a, b);
}

ENet.eNET_VERSION = function() {
	return ENet.eNET_VERSION_CREATE(1, 3, 8);
}

ENet.eNET_VERSION_CREATE = function(major, minor, patch) {
	return major << 16 | minor << 8 | patch;
}

ENet.eNET_VERSION_GET_MAJOR = function(version) {
	return version >> 16 & 255;
}

ENet.eNET_VERSION_GET_MINOR = function(version) {
	return version >> 8 & 255;
}

ENet.eNET_VERSION_GET_PATCH = function(version) {
	return version & 255;
}
ENet.E_N_E_T__V_E_R_S_I_O_N__M_A_J_O_R = 1;
ENet.E_N_E_T__V_E_R_S_I_O_N__M_I_N_O_R = 3;
ENet.E_N_E_T__V_E_R_S_I_O_N__P_A_T_C_H = 8;

ENet.prototype.readByte = function(currentData, currentDataI) {
	return currentData[currentDataI];
}

ENet.prototype.readInt = function(readBuf, readPos) {
	var n = readBuf[readPos + 3] << 24;
	n |= readBuf[readPos + 2] << 16;
	n |= readBuf[readPos + 1] << 8;
	n |= readBuf[readPos + 0];
	return n;
}

ENet.prototype.readShort = function(readBuf, readPos) {
	var n = readBuf[readPos + 1] << 8;
	n |= readBuf[readPos + 0];
	readPos += 2;
	return this.p.intToUshort(n);
}
ENet.S_O_C_K_E_T__E_R_R_O_R = -1;

ENet.prototype.serializeCommand = function(buf, a) {
	if (a == null) {
		a = new ENetProtocol();
	}
	var pos = new Int32Array(new ArrayBuffer(1 << 2));
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

ENet.prototype.serializeHeader = function(headerData, header) {
	var pos = new Int32Array(new ArrayBuffer(1 << 2));
	pos[0] = 0;
	this.writeShort(headerData, pos, header.peerID);
	this.writeShort(headerData, pos, header.sentTime);
}

ENet.prototype.setPlatform = function(value) {
	this.p = value;
}

ENet.toByte = function(a) {
	return a & 0xff;
}

ENet.prototype.toUint16 = function(a) {
	return this.p.intToUshort(a);
}

ENet.prototype.writeByte = function(data, pos, value) {
	var pos_ = pos[0];
	data[pos_] = ENet.toByte(value);
	pos[0] += 1;
}

ENet.prototype.writeInt = function(data, pos, n) {
	var pos_ = pos[0];
	data[pos_ + 3] = ENet.toByte(n >> 24 & 255);
	data[pos_ + 2] = ENet.toByte(n >> 16 & 255);
	data[pos_ + 1] = ENet.toByte(n >> 8 & 255);
	data[pos_ + 0] = ENet.toByte(n & 255);
	pos[0] += 4;
}

ENet.prototype.writeShort = function(data, pos, value) {
	var pos_ = pos[0];
	data[pos_] = ENet.toByte(value & 255);
	data[pos_ + 1] = ENet.toByte(value >> 8 & 255);
	pos[0] += 2;
}

ENet.prototype.commandError = function(event_) {
	if (event_ != null && event_.type != ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
		return 1;
	return 0;
}

ENet.prototype.enet_address_set_host = function(address, hostName) {
	return this.p.enet_address_set_host(address, hostName);
}

ENet.prototype.enet_crc32 = function(buffers, bufferCount) {
	var crc = -1;
	if (!this.initializedCRC32)
		this.initialize_crc32();
	for (var buf = 0; buf < bufferCount; buf++) {
		var data = buffers[buf].data;
		var dataLength = buffers[buf].dataLength;
		for (var i = 0; i < dataLength; i++) {
			crc = crc >> 8 ^ this.crcTable[crc & 255 ^ data[i]];
		}
	}
	return this.p.eNET_HOST_TO_NET_32(~crc);
}

ENet.prototype.enet_deinitialize = function() {
}

ENet.prototype.enet_host_bandwidth_limit = function(host, incomingBandwidth, outgoingBandwidth) {
	host.incomingBandwidth = incomingBandwidth;
	host.outgoingBandwidth = outgoingBandwidth;
	host.recalculateBandwidthLimits = 1;
}

ENet.prototype.enet_host_bandwidth_throttle = function(host) {
	var timeCurrent = this.p.enet_time_get();
	var elapsedTime = timeCurrent - host.bandwidthThrottleEpoch;
	var peersRemaining = host.connectedPeers;
	var dataTotal = ~0;
	var bandwidth = ~0;
	var throttle = 0;
	var bandwidthLimit = 0;
	var needsAdjustment = host.bandwidthLimitedPeers > 0 ? 1 : 0;
	var peer;
	var command = new ENetProtocol();
	if (elapsedTime < 1000)
		return;
	host.bandwidthThrottleEpoch = timeCurrent;
	if (peersRemaining == 0)
		return;
	if (host.outgoingBandwidth != 0) {
		dataTotal = 0;
		bandwidth = Math.floor(host.outgoingBandwidth * elapsedTime / 1000);
		for (var i = 0; i < host.peerCount; i++) {
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
			throttle = Math.floor(bandwidth * 32 / dataTotal);
		for (var i = 0; i < host.peerCount; i++) {
			peer = host.peers[i];
			var peerBandwidth;
			if (peer.state != 5 && peer.state != 6 || peer.incomingBandwidth == 0 || peer.outgoingBandwidthThrottleEpoch == timeCurrent)
				continue;
			peerBandwidth = Math.floor(peer.incomingBandwidth * elapsedTime / 1000);
			if (Math.floor(throttle * peer.outgoingDataTotal / 32) <= peerBandwidth)
				continue;
			peer.packetThrottleLimit = Math.floor(peerBandwidth * 32 / peer.outgoingDataTotal);
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
			throttle = Math.floor(bandwidth * 32 / dataTotal);
		for (var i = 0; i < host.peerCount; i++) {
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
				bandwidthLimit = Math.floor(bandwidth / peersRemaining);
				for (var i = 0; i < host.peerCount; i++) {
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
		for (var i = 0; i < host.peerCount; i++) {
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

ENet.prototype.enet_host_broadcast = function(host, channelID, packet) {
	var currentPeer;
	for (var i = 0; i < host.peerCount; i++) {
		currentPeer = host.peers[i];
		if (currentPeer.state != 5)
			continue;
		this.enet_peer_send(currentPeer, channelID, packet);
	}
	if (packet.referenceCount == 0)
		this.enet_packet_destroy(packet);
}

ENet.prototype.enet_host_channel_limit = function(host, channelLimit) {
	if (channelLimit == 0 || channelLimit > 255)
		channelLimit = 255;
	else if (channelLimit < 1)
		channelLimit = 1;
	host.channelLimit = channelLimit;
}

ENet.prototype.enet_host_check_events = function(host, event_) {
	if (event_ == null)
		return -1;
	event_.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E;
	event_.peer = null;
	event_.packet = null;
	return this.enet_protocol_dispatch_incoming_commands(host, event_);
}

ENet.prototype.enet_host_compress = function(host, compressor) {
	if (host.compressor != null)
		host.compressor.destroy();
	if (compressor != null)
		host.compressor = compressor;
	else
		host.compressor = null;
}

ENet.prototype.enet_host_compress_with_range_coder = function(host) {
	return 0;
}

ENet.prototype.enet_host_connect = function(host, address, channelCount, data) {
	var currentPeer = null;
	var channel;
	var command = new ENetProtocol();
	if (channelCount < 1)
		channelCount = 1;
	else if (channelCount > 255)
		channelCount = 255;
	for (var i = 0; i < host.peerCount; i++) {
		currentPeer = host.peers[i];
		if (currentPeer.state == 0)
			break;
	}
	if (host.peerCount == 0) {
		return null;
	}
	currentPeer.channels = new Array(channelCount);
	for (var i = 0; i < channelCount; i++) {
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
		currentPeer.windowSize = Math.floor(host.outgoingBandwidth / 65536) * 4096;
	if (currentPeer.windowSize < 4096)
		currentPeer.windowSize = 4096;
	else if (currentPeer.windowSize > 32768)
		currentPeer.windowSize = 32768;
	for (var i = 0; i < channelCount; i++) {
		channel = currentPeer.channels[i];
		channel.outgoingReliableSequenceNumber = 0;
		channel.outgoingUnreliableSequenceNumber = 0;
		channel.incomingReliableSequenceNumber = 0;
		channel.incomingUnreliableSequenceNumber = 0;
		this.enet_list_clear(channel.incomingReliableCommands);
		this.enet_list_clear(channel.incomingUnreliableCommands);
		channel.usedReliableWindows = 0;
		for (var k = 0; k < 16; k++) {
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

ENet.prototype.enet_host_create = function(address, peerCount, channelLimit, incomingBandwidth, outgoingBandwidth) {
	var host;
	var currentPeer;
	if (peerCount > 4095)
		return null;
	host = new ENetHost();
	if (host == null)
		return null;
	host.peers = new Array(peerCount);
	if (host.peers == null) {
		return null;
	}
	for (var i = 0; i < peerCount; i++) {
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
	for (var i = 0; i < host.peerCount; i++) {
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

ENet.prototype.enet_host_destroy = function(host) {
	var currentPeer;
	if (host == null)
		return;
	this.p.enet_socket_destroy(host.socket);
	for (var i = 0; i < host.peerCount; i++) {
		currentPeer = host.peers[i];
		this.enet_peer_reset(currentPeer);
	}
	if (host.compressor != null)
		host.compressor.destroy();
}

ENet.prototype.enet_host_flush = function(host) {
	host.serviceTime = this.p.enet_time_get();
	this.enet_protocol_send_outgoing_commands(host, null, 0);
}

ENet.prototype.enet_host_service = function(host, event_, timeout) {
	var waitCondition = new Int32Array(new ArrayBuffer(1 << 2));
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

ENet.prototype.enet_initialize = function() {
	return 0;
}

ENet.prototype.enet_list_back = function(list) {
	return this.p.castToENetListNode(this.p.castToENetListNode(list.getSentinel()).previous);
}

ENet.prototype.enet_list_begin = function(list) {
	return this.p.castToENetListNode(this.p.castToENetListNode(list.getSentinel()).next);
}

ENet.prototype.enet_list_clear = function(list) {
	this.p.castToENetListNode(list.getSentinel()).next = list.getSentinel();
	this.p.castToENetListNode(list.getSentinel()).previous = list.getSentinel();
}

ENet.prototype.enet_list_empty = function(list) {
	return this.enet_list_begin(list) == this.enet_list_end(list);
}

ENet.prototype.enet_list_end = function(list) {
	return this.p.castToENetListNode(list.getSentinel());
}

ENet.prototype.enet_list_front = function(list) {
	return this.p.castToENetListNode(this.p.castToENetListNode(list.getSentinel()).next);
}

ENet.prototype.enet_list_insert = function(position, data) {
	var result = this.p.castToENetListNode(data);
	result.previous = position.previous;
	result.next = position;
	this.p.castToENetListNode(result.previous).next = result;
	position.previous = result;
	return result;
}

ENet.prototype.enet_list_move = function(position, dataFirst, dataLast) {
	var first = dataFirst;
	var last = dataLast;
	this.p.castToENetListNode(first.previous).next = last.next;
	this.p.castToENetListNode(last.next).previous = first.previous;
	first.previous = position.previous;
	last.next = position;
	this.p.castToENetListNode(first.previous).next = first;
	position.previous = last;
	return first;
}

ENet.prototype.enet_list_next = function(iterator) {
	return this.p.castToENetListNode(iterator.next);
}

ENet.prototype.enet_list_previous = function(iterator) {
	return this.p.castToENetListNode(iterator.previous);
}

ENet.prototype.enet_list_remove = function(position) {
	this.p.castToENetListNode(position.previous).next = position.next;
	this.p.castToENetListNode(position.next).previous = position.previous;
	return position;
}

ENet.prototype.enet_list_size = function(list) {
	var size = 0;
	var position;
	for (position = this.enet_list_begin(list); position != this.enet_list_end(list); position = this.enet_list_next(position))
		size++;
	return size;
}

ENet.prototype.enet_packet_create = function(data, dataLength, flags) {
	var packet = new ENetPacket();
	if (packet == null)
		return null;
	if ((flags & 4) != 0)
		packet.data = data;
	else if (dataLength <= 0)
		packet.data = null;
	else {
		packet.data = new Uint8Array(new ArrayBuffer(dataLength));
		if (packet.data == null) {
			return null;
		}
		if (data != null) {
			for (var i = 0; i < dataLength; i++) {
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

ENet.prototype.enet_packet_destroy = function(packet) {
	if (packet == null)
		return;
	if (packet.freeCallback != null)
		packet.freeCallback.run(packet);
	if ((packet.flags & 4) == 0 && packet.data != null) {
	}
}

ENet.prototype.enet_packet_resize = function(packet, dataLength) {
	var newData;
	if (dataLength <= packet.dataLength || (packet.flags & 4) != 0) {
		packet.dataLength = dataLength;
		return 0;
	}
	newData = new Uint8Array(new ArrayBuffer(dataLength));
	if (newData == null)
		return -1;
	this.memcpy(newData, packet.data, packet.dataLength);
	packet.data = newData;
	packet.dataLength = dataLength;
	return 0;
}

ENet.prototype.enet_peer_disconnect = function(peer, data) {
	var command = new ENetProtocol();
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

ENet.prototype.enet_peer_disconnect_later = function(peer, data) {
	if ((peer.state == 5 || peer.state == 6) && !(this.enet_list_empty(peer.outgoingReliableCommands) && this.enet_list_empty(peer.outgoingUnreliableCommands) && this.enet_list_empty(peer.sentReliableCommands))) {
		peer.state = 6;
		peer.eventData = data;
	}
	else
		this.enet_peer_disconnect(peer, data);
}

ENet.prototype.enet_peer_disconnect_now = function(peer, data) {
	var command = new ENetProtocol();
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

ENet.prototype.enet_peer_dispatch_incoming_reliable_commands = function(peer, channel) {
	var currentCommand;
	for (currentCommand = this.enet_list_begin(channel.incomingReliableCommands); currentCommand != this.enet_list_end(channel.incomingReliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
		var incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
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

ENet.prototype.enet_peer_dispatch_incoming_unreliable_commands = function(peer, channel) {
	var droppedCommand;
	var startCommand;
	var currentCommand;
	for (droppedCommand = startCommand = currentCommand = this.enet_list_begin(channel.incomingUnreliableCommands); currentCommand != this.enet_list_end(channel.incomingUnreliableCommands); currentCommand = this.enet_list_next(currentCommand)) {
		var incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
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
			var reliableWindow = this.p.intToUshort(Math.floor(incomingCommand.reliableSequenceNumber / 4096));
			var currentWindow = this.p.intToUshort(Math.floor(channel.incomingReliableSequenceNumber / 4096));
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

ENet.prototype.enet_peer_on_connect = function(peer) {
	if (peer.state != 5 && peer.state != 6) {
		if (peer.incomingBandwidth != 0)
			peer.host.bandwidthLimitedPeers++;
		peer.host.connectedPeers++;
	}
}

ENet.prototype.enet_peer_on_disconnect = function(peer) {
	if (peer.state == 5 || peer.state == 6) {
		if (peer.incomingBandwidth != 0)
			peer.host.bandwidthLimitedPeers--;
		peer.host.connectedPeers--;
	}
}

ENet.prototype.enet_peer_ping = function(peer) {
	var command = new ENetProtocol();
	if (peer.state != 5)
		return;
	command.header.command = 133;
	command.header.channelID = 255;
	this.enet_peer_queue_outgoing_command(peer, command, null, 0, 0);
}

ENet.prototype.enet_peer_ping_interval = function(peer, pingInterval) {
	peer.pingInterval = pingInterval != 0 ? pingInterval : 500;
}

ENet.prototype.enet_peer_queue_acknowledgement = function(peer, command, sentTime) {
	var acknowledgement;
	if (command.header.channelID < peer.channelCount) {
		var channel = peer.channels[command.header.channelID];
		var reliableWindow = this.p.intToUshort(Math.floor(command.header.reliableSequenceNumber / 4096));
		var currentWindow = this.p.intToUshort(Math.floor(channel.incomingReliableSequenceNumber / 4096));
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

ENet.prototype.enet_peer_queue_incoming_command = function(peer, command, packet, fragmentCount) {
	var channel = peer.channels[command.header.channelID];
	var unreliableSequenceNumber = 0;
	var reliableSequenceNumber = 0;
	var reliableWindow;
	var currentWindow;
	var incomingCommand = null;
	var currentCommand;
	if (peer.state == 6) {
		return this.freePacket(fragmentCount, packet);
	}
	if ((command.header.command & 15) != 9) {
		reliableSequenceNumber = command.header.reliableSequenceNumber;
		reliableWindow = Math.floor(reliableSequenceNumber / 4096);
		currentWindow = Math.floor(channel.incomingReliableSequenceNumber / 4096);
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
			incomingCommand.fragments = new Int32Array(new ArrayBuffer(Math.floor((fragmentCount + 31) / 32) << 2));
		if (incomingCommand.fragments == null) {
			return this.notifyError(packet);
		}
		for (var i = 0; i < Math.floor((fragmentCount + 31) / 32); i++) {
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

ENet.prototype.enet_peer_queue_outgoing_command = function(peer, command, packet, offset, length) {
	var outgoingCommand = new ENetOutgoingCommand();
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

ENet.prototype.enet_peer_receive = function(peer, channelID) {
	var incomingCommand;
	var packet;
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

ENet.prototype.enet_peer_remove_incoming_commands = function(queue, startCommand, endCommand) {
	var currentCommand;
	for (currentCommand = startCommand; currentCommand != endCommand;) {
		var incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
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

ENet.prototype.enet_peer_reset = function(peer) {
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
	for (var i = 0; i < 32; i++) {
		peer.unsequencedWindow[i] = 0;
	}
	this.enet_peer_reset_queues(peer);
}

ENet.prototype.enet_peer_reset_incoming_commands = function(queue) {
	this.enet_peer_remove_incoming_commands(queue, this.enet_list_begin(queue), this.enet_list_end(queue));
}

ENet.prototype.enet_peer_reset_outgoing_commands = function(queue) {
	var outgoingCommand;
	while (!this.enet_list_empty(queue)) {
		outgoingCommand = this.p.castToENetOutgoingCommand(this.enet_list_remove(this.enet_list_begin(queue)));
		if (outgoingCommand.packet != null) {
			outgoingCommand.packet.referenceCount--;
			if (outgoingCommand.packet.referenceCount == 0)
				this.enet_packet_destroy(outgoingCommand.packet);
		}
	}
}

ENet.prototype.enet_peer_reset_queues = function(peer) {
	var channel;
	if (peer.needsDispatch != 0) {
		this.enet_list_remove(peer.dispatchList());
		peer.needsDispatch = 0;
	}
	while (!this.enet_list_empty(peer.acknowledgements)) {
		var n = this.enet_list_remove(this.enet_list_begin(peer.acknowledgements));
	}
	this.enet_peer_reset_outgoing_commands(peer.sentReliableCommands);
	this.enet_peer_reset_outgoing_commands(peer.sentUnreliableCommands);
	this.enet_peer_reset_outgoing_commands(peer.outgoingReliableCommands);
	this.enet_peer_reset_outgoing_commands(peer.outgoingUnreliableCommands);
	this.enet_peer_reset_incoming_commands(peer.dispatchedCommands);
	if (peer.channels != null && peer.channelCount > 0) {
		for (var i = 0; i < peer.channelCount; i++) {
			channel = peer.channels[i];
			this.enet_peer_reset_incoming_commands(channel.incomingReliableCommands);
			this.enet_peer_reset_incoming_commands(channel.incomingUnreliableCommands);
		}
	}
	peer.channels = null;
	peer.channelCount = 0;
}

ENet.prototype.enet_peer_send = function(peer, channelID, packet) {
	var channel = peer.channels[channelID];
	var command = new ENetProtocol();
	var fragmentLength;
	if (peer.state != 5 || channelID >= peer.channelCount || packet.dataLength > 1073741824)
		return -1;
	fragmentLength = peer.mtu - 4 - 28;
	if (peer.host.checksum != null)
		fragmentLength -= 4;
	if (packet.dataLength > fragmentLength) {
		var fragmentCount = Math.floor((packet.dataLength + fragmentLength - 1) / fragmentLength);
		var fragmentNumber;
		var fragmentOffset;
		var commandNumber;
		var startSequenceNumber;
		var fragments = null;
		var fragment;
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

ENet.prototype.enet_peer_setup_outgoing_command = function(peer, outgoingCommand) {
	var channel = null;
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

ENet.prototype.enet_peer_throttle = function(peer, rtt) {
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

ENet.prototype.enet_peer_throttle_configure = function(peer, interval, acceleration, deceleration) {
	var command = new ENetProtocol();
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

ENet.prototype.enet_peer_timeout = function(peer, timeoutLimit, timeoutMinimum, timeoutMaximum) {
	peer.timeoutLimit = timeoutLimit != 0 ? timeoutLimit : 32;
	peer.timeoutMinimum = timeoutMinimum != 0 ? timeoutMinimum : 5000;
	peer.timeoutMaximum = timeoutMaximum != 0 ? timeoutMaximum : 30000;
}

ENet.prototype.enet_protocol_change_state = function(host, peer, state) {
	if (state == 5 || state == 6)
		this.enet_peer_on_connect(peer);
	else
		this.enet_peer_on_disconnect(peer);
	peer.state = state;
}

ENet.prototype.enet_protocol_check_timeouts = function(host, peer, event_) {
	var outgoingCommand = null;
	var currentCommand;
	var insertPosition;
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

ENet.prototype.enet_protocol_command_size = function(commandNumber) {
	return this.commandSizes[commandNumber & 15];
}

ENet.prototype.enet_protocol_dispatch_incoming_commands = function(host, event_) {
	while (!this.enet_list_empty(host.dispatchQueue)) {
		var peer = this.p.castToENetPeer(this.enet_list_remove(this.enet_list_begin(host.dispatchQueue)));
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
			var b = new Byte();
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

ENet.prototype.enet_protocol_dispatch_state = function(host, peer, state) {
	this.enet_protocol_change_state(host, peer, state);
	if (peer.needsDispatch == 0) {
		this.enet_list_insert(this.enet_list_end(host.dispatchQueue), peer.dispatchList());
		peer.needsDispatch = 1;
	}
}

ENet.prototype.enet_protocol_handle_acknowledge = function(host, event_, peer, command) {
	var roundTripTime;
	var receivedSentTime;
	var receivedReliableSequenceNumber;
	var commandNumber;
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
	peer.roundTripTimeVariance -= Math.floor(peer.roundTripTimeVariance / 4);
	if (roundTripTime >= peer.roundTripTime) {
		peer.roundTripTime += Math.floor((roundTripTime - peer.roundTripTime) / 8);
		peer.roundTripTimeVariance += Math.floor((roundTripTime - peer.roundTripTime) / 4);
	}
	else {
		peer.roundTripTime -= Math.floor((peer.roundTripTime - roundTripTime) / 8);
		peer.roundTripTimeVariance += Math.floor((peer.roundTripTime - roundTripTime) / 4);
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

ENet.prototype.enet_protocol_handle_bandwidth_limit = function(host, peer, command) {
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
		peer.windowSize = Math.floor(this.eNET_MIN(peer.incomingBandwidth, host.outgoingBandwidth) / 65536) * 4096;
	if (peer.windowSize < 4096)
		peer.windowSize = 4096;
	else if (peer.windowSize > 32768)
		peer.windowSize = 32768;
	return 0;
}

ENet.prototype.enet_protocol_handle_connect = function(host, header, command) {
	var incomingSessionID;
	var outgoingSessionID;
	var mtu;
	var windowSize;
	var channel;
	var channelCount;
	var currentPeer = new ENetPeer();
	var verifyCommand = new ENetProtocol();
	channelCount = this.p.eNET_NET_TO_HOST_32(command.connect.channelCount);
	if (channelCount < 1 || channelCount > 255)
		return null;
	var i;
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
	for (var k = 0; k < channelCount; k++) {
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
		for (var k = 0; k < 16; k++) {
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
		currentPeer.windowSize = Math.floor(this.eNET_MAX(host.outgoingBandwidth, currentPeer.incomingBandwidth) / 65536) * 4096;
	else
		currentPeer.windowSize = Math.floor(this.eNET_MIN(host.outgoingBandwidth, currentPeer.incomingBandwidth) / 65536) * 4096;
	if (currentPeer.windowSize < 4096)
		currentPeer.windowSize = 4096;
	else if (currentPeer.windowSize > 32768)
		currentPeer.windowSize = 32768;
	if (host.incomingBandwidth == 0)
		windowSize = 32768;
	else
		windowSize = Math.floor(host.incomingBandwidth / 65536) * 4096;
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

ENet.prototype.enet_protocol_handle_disconnect = function(host, peer, command) {
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

ENet.prototype.enet_protocol_handle_incoming_commands = function(host, event_) {
	var header;
	var command = null;
	var peer;
	var currentData = null;
	var headerSize = 0;
	var peerID;
	var flags;
	var sessionID;
	var currentDataI = new Int32Array(new ArrayBuffer(1 << 2));
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
		var originalSize = 0;
		if (host.compressor == null)
			return 0;
		for (var i = 0; i < headerSize; i++) {
		}
		host.receivedData = host.packetData[1];
		host.receivedDataLength = headerSize + originalSize;
	}
	if (host.checksum != null) {
		var checksum = 0;
		var desiredChecksum = checksum;
		var buffer = new ENetBuffer();
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
	var test = 0;
	while (currentDataI[0] < host.receivedDataLength) {
		var commandNumber;
		var commandSize;
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
			var sentTime;
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

ENet.prototype.enet_protocol_handle_ping = function(host, peer, command) {
	if (peer.state != 5 && peer.state != 6)
		return -1;
	return 0;
}

ENet.prototype.enet_protocol_handle_send_fragment = function(host, peer, command, currentData, currentDataI) {
	var fragmentNumber;
	var fragmentCount;
	var fragmentOffset;
	var fragmentLength;
	var startSequenceNumber;
	var totalLength;
	var channel;
	var startWindow;
	var currentWindow;
	var currentCommand;
	var startCommand = null;
	if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
		return -1;
	fragmentLength = this.p.eNET_NET_TO_HOST_16(command.sendFragment.dataLength);
	currentDataI[0] += fragmentLength;
	if (fragmentLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
		return -1;
	channel = peer.channels[command.header.channelID];
	startSequenceNumber = this.p.eNET_NET_TO_HOST_16(command.sendFragment.startSequenceNumber);
	startWindow = this.p.intToUshort(Math.floor(startSequenceNumber / 4096));
	currentWindow = this.p.intToUshort(Math.floor(channel.incomingReliableSequenceNumber / 4096));
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
		var incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
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
		var hostCommand = command;
		var packet = this.enet_packet_create(null, totalLength, 1);
		if (packet == null)
			return -1;
		hostCommand.header.reliableSequenceNumber = this.p.intToUshort(startSequenceNumber);
		startCommand = this.enet_peer_queue_incoming_command(peer, hostCommand, packet, fragmentCount);
		if (startCommand == null)
			return -1;
	}
	if ((startCommand.fragments[Math.floor(fragmentNumber / 32)] & 1 << fragmentNumber % 32) == 0) {
		startCommand.fragmentsRemaining--;
		startCommand.fragments[Math.floor(fragmentNumber / 32)] |= 1 << fragmentNumber % 32;
		if (fragmentOffset + fragmentLength > startCommand.packet.dataLength)
			fragmentLength = startCommand.packet.dataLength - fragmentOffset;
		var data = new Uint8Array(new ArrayBuffer(128));
		this.serializeCommand(data, command);
		for (var i = 0; i < fragmentLength; i++) {
			startCommand.packet.data[i + fragmentOffset] = data[i + 28];
		}
		if (startCommand.fragmentsRemaining <= 0)
			this.enet_peer_dispatch_incoming_reliable_commands(peer, channel);
	}
	return 0;
}

ENet.prototype.enet_protocol_handle_send_reliable = function(host, peer, command, currentData, currentDataI) {
	var packet;
	var dataLength;
	if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
		return -1;
	dataLength = this.eNET_NET_TO_HOST_16(command.sendReliable.dataLength);
	if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
		return -1;
	command.data = new Uint8Array(new ArrayBuffer(dataLength));
	for (var i = 0; i < dataLength; i++) {
		command.data[i] = currentData[currentDataI[0] + i];
	}
	currentDataI[0] += dataLength;
	packet = this.enet_packet_create(command.data, dataLength, 1);
	if (packet == null || this.enet_peer_queue_incoming_command(peer, command, packet, 0) == null)
		return -1;
	return 0;
}

ENet.prototype.enet_protocol_handle_send_unreliable = function(host, peer, command, currentData, currentDataI) {
	var packet;
	var dataLength;
	if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
		return -1;
	dataLength = this.p.eNET_NET_TO_HOST_16(command.sendUnreliable.dataLength);
	currentDataI[0] += dataLength;
	if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host.receivedDataLength)
		return -1;
	command.data = new Uint8Array(new ArrayBuffer(dataLength));
	for (var i = 0; i < dataLength; i++) {
		command.data[i] = currentData[currentDataI[0] - dataLength + i];
	}
	packet = this.enet_packet_create(command.data, dataLength, 0);
	if (packet == null || this.enet_peer_queue_incoming_command(peer, command, packet, 0) == null)
		return -1;
	return 0;
}

ENet.prototype.enet_protocol_handle_send_unreliable_fragment = function(host, peer, command, currentData) {
	var fragmentNumber;
	var fragmentCount;
	var fragmentOffset;
	var fragmentLength;
	var reliableSequenceNumber;
	var startSequenceNumber;
	var totalLength;
	var reliableWindow;
	var currentWindow;
	var channel;
	var currentCommand;
	var startCommand = null;
	if (command.header.channelID >= peer.channelCount || peer.state != 5 && peer.state != 6)
		return -1;
	fragmentLength = this.eNET_NET_TO_HOST_16(command.sendFragment.dataLength);
	var currentDataI = 0;
	currentDataI += fragmentLength;
	if (fragmentLength > 1073741824 || currentDataI < 0 || currentDataI > host.receivedDataLength)
		return -1;
	channel = peer.channels[command.header.channelID];
	reliableSequenceNumber = command.header.reliableSequenceNumber;
	startSequenceNumber = this.eNET_NET_TO_HOST_16(command.sendFragment.startSequenceNumber);
	reliableWindow = this.p.intToUshort(Math.floor(reliableSequenceNumber / 4096));
	currentWindow = this.p.intToUshort(Math.floor(channel.incomingReliableSequenceNumber / 4096));
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
		var incomingCommand = this.p.castToENetIncomingCommand(currentCommand);
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
		var packet = this.enet_packet_create(null, totalLength, 8);
		if (packet == null)
			return -1;
		startCommand = this.enet_peer_queue_incoming_command(peer, command, packet, fragmentCount);
		if (startCommand == null)
			return -1;
	}
	if ((startCommand.fragments[Math.floor(fragmentNumber / 32)] & 1 << fragmentNumber % 32) == 0) {
		startCommand.fragmentsRemaining--;
		startCommand.fragments[Math.floor(fragmentNumber / 32)] |= 1 << fragmentNumber % 32;
		if (fragmentOffset + fragmentLength > startCommand.packet.dataLength)
			fragmentLength = startCommand.packet.dataLength - fragmentOffset;
		for (var i = 0; i < fragmentLength; i++) {
			startCommand.packet.data[fragmentOffset + i] = command.data[i];
		}
		if (startCommand.fragmentsRemaining <= 0)
			this.enet_peer_dispatch_incoming_unreliable_commands(peer, channel);
	}
	return 0;
}

ENet.prototype.enet_protocol_handle_send_unsequenced = function(host, peer, command, currentData) {
	return 0;
}

ENet.prototype.enet_protocol_handle_throttle_configure = function(host, peer, command) {
	if (peer.state != 5 && peer.state != 6)
		return -1;
	peer.packetThrottleInterval = this.p.eNET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleInterval);
	peer.packetThrottleAcceleration = this.p.eNET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleAcceleration);
	peer.packetThrottleDeceleration = this.p.eNET_NET_TO_HOST_32(command.throttleConfigure.packetThrottleDeceleration);
	return 0;
}

ENet.prototype.enet_protocol_handle_verify_connect = function(host, event_, peer, command) {
	var mtu;
	var windowSize;
	var channelCount;
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

ENet.prototype.enet_protocol_notify_connect = function(host, peer, event_) {
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

ENet.prototype.enet_protocol_notify_disconnect = function(host, peer, event_) {
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

ENet.prototype.enet_protocol_receive_incoming_commands = function(host, event_) {
	for (;;) {
		var receivedLength;
		var buffer = new ENetBuffer();
		buffer.data = host.packetData[0];
		buffer.dataLength = 4096;
		var buffers = new Array(1);
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
}

ENet.prototype.enet_protocol_remove_sent_reliable_command = function(peer, reliableSequenceNumber, channelID) {
	var outgoingCommand = null;
	var currentCommand;
	var commandNumber;
	var wasSent = 1;
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
		var channel = peer.channels[channelID];
		var reliableWindow = this.p.intToUshort(Math.floor(reliableSequenceNumber / 4096));
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

ENet.prototype.enet_protocol_remove_sent_unreliable_commands = function(peer) {
	var outgoingCommand;
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

ENet.prototype.enet_protocol_send_acknowledgements = function(host, peer) {
	var commandI = host.commandCount;
	var bufferI = host.bufferCount;
	var acknowledgement;
	var currentAcknowledgement;
	var reliableSequenceNumber;
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
		var buf = new Uint8Array(new ArrayBuffer(128));
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

ENet.prototype.enet_protocol_send_outgoing_commands = function(host, event_, checkForTimeouts) {
	var headerData = new Uint8Array(new ArrayBuffer(8));
	var header = new ENetProtocolHeader();
	var currentPeer;
	var sentLength;
	var shouldCompress = 0;
	host.continueSending = 1;
	while (host.continueSending != 0) {
		host.continueSending = 0;
		for (var i = 0; i < host.peerCount; i++) {
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
				var packetLoss = Math.floor(currentPeer.packetsLost * 65536 / currentPeer.packetsSent);
				currentPeer.packetLossVariance -= Math.floor(currentPeer.packetLossVariance / 4);
				if (packetLoss >= currentPeer.packetLoss) {
					currentPeer.packetLoss += Math.floor((packetLoss - currentPeer.packetLoss) / 8);
					currentPeer.packetLossVariance += Math.floor((packetLoss - currentPeer.packetLoss) / 4);
				}
				else {
					currentPeer.packetLoss -= Math.floor((currentPeer.packetLoss - packetLoss) / 8);
					currentPeer.packetLossVariance += Math.floor((currentPeer.packetLoss - packetLoss) / 4);
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

ENet.prototype.enet_protocol_send_reliable_outgoing_commands = function(host, peer) {
	var commandI = host.commandCount;
	var bufferI = host.bufferCount;
	var outgoingCommand;
	var currentCommand;
	var channel;
	var reliableWindow;
	var commandSize;
	var windowExceeded = 0;
	var windowWrap = 0;
	var canPing = 1;
	currentCommand = this.enet_list_begin(peer.outgoingReliableCommands);
	if (this.test1 == 1) {
		this.test1 = this.test1;
	}
	while (currentCommand != this.enet_list_end(peer.outgoingReliableCommands)) {
		outgoingCommand = this.p.castToENetOutgoingCommand(currentCommand);
		channel = outgoingCommand.command.header.channelID < peer.channelCount ? peer.channels[outgoingCommand.command.header.channelID] : null;
		reliableWindow = this.p.intToUshort(Math.floor(outgoingCommand.reliableSequenceNumber / 4096));
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
				var windowSize = Math.floor(peer.packetThrottle * peer.windowSize / 32);
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
		var command = outgoingCommand.command;
		host.commands[commandI] = command;
		host.buffers[bufferI].data = new Uint8Array(new ArrayBuffer(commandSize));
		this.serializeCommand(host.buffers[bufferI].data, host.commands[commandI]);
		host.buffers[bufferI].dataLength = commandSize;
		host.packetSize += host.buffers[bufferI].dataLength;
		host.headerFlags |= 32768;
		if (outgoingCommand.packet != null) {
			bufferI++;
			var data = new Uint8Array(new ArrayBuffer(outgoingCommand.packet.dataLength));
			for (var i = 0; i < outgoingCommand.packet.dataLength - outgoingCommand.fragmentOffset; i++) {
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

ENet.prototype.enet_protocol_send_unreliable_outgoing_commands = function(host, peer) {
}

ENet.prototype.freePacket = function(fragmentCount, packet) {
	if (fragmentCount > 0)
		return this.notifyError(packet);
	if (packet != null && packet.referenceCount == 0)
		this.enet_packet_destroy(packet);
	return this.dummyCommand;
}

ENet.prototype.initialize_crc32 = function() {
	this.crcTable = new Int32Array(new ArrayBuffer(256 << 2));
	var byte_;
	var c = -2147483647;
	c -= 1;
	for (byte_ = 0; byte_ < 256; byte_++) {
		var crc = ENet.reflect_crc(byte_, 8) << 24;
		var offset;
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

ENet.prototype.memcpy = function(destination, source, num) {
	for (var i = 0; i < num; i++) {
		destination[i] = source[i];
	}
}

ENet.prototype.notifyError = function(packet) {
	if (packet != null && packet.referenceCount == 0)
		this.enet_packet_destroy(packet);
	return null;
}

ENet.reflect_crc = function(val, bits) {
	var result = 0;
	var bit;
	for (bit = 0; bit < bits; bit++) {
		if ((val & 1) != 0)
			result |= 1 << bits - 1 - bit;
		val >>= 1;
	}
	return result;
}

function ENetObject()
{
}

function ENetListNode()
{
	this.data = null;
	this.next = null;
	this.previous = null;
}
ENetListNode.prototype = new ENetObject();

function ENetAcknowledgement()
{
	this.command = null;
	this.sentTime = 0;
}
ENetAcknowledgement.prototype = new ENetListNode();

ENetAcknowledgement.prototype.acknowledgementList = function() {
	return this;
}

function ENetAddress()
{
	this.host = 0;
	this.port = 0;
}

ENetAddress.clone = function(address) {
	var other = new ENetAddress();
	other.host = address.host;
	other.port = address.port;
	return other;
}

function ENetBuffer()
{
	this.data = null;
	this.dataLength = 0;
}

function ENetChannel()
{
	this.incomingReliableCommands = null;
	this.incomingReliableSequenceNumber = 0;
	this.incomingUnreliableCommands = null;
	this.incomingUnreliableSequenceNumber = 0;
	this.outgoingReliableSequenceNumber = null;
	this.outgoingUnreliableSequenceNumber = null;
	this.reliableWindows = null;
	this.usedReliableWindows = 0;
	this.reliableWindows = new Int32Array(new ArrayBuffer(16 << 2));
	this.incomingReliableCommands = new ENetList();
	this.incomingUnreliableCommands = new ENetList();
}
ENetChannel.RELIABLE_WINDOWS_LENGTH = 16;

function ENetChecksumCallback()
{
}

function ENetCompressor()
{
}

function ENetCompressorContext()
{
}

function ENetEvent()
{
	this.channelID = 0;
	this.data = 0;
	this.packet = null;
	this.peer = null;
	this.type = ENetEventType.E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E;
}

var ENetEventType = {
	E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E : 0,
	E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T : 1,
	E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T : 2,
	E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E : 3
}

function ENetHost()
{
	this.address = null;
	this.bandwidthLimitedPeers = 0;
	this.bandwidthThrottleEpoch = 0;
	this.bufferCount = 0;
	this.buffers = null;
	this.channelLimit = 0;
	this.checksum = null;
	this.commandCount = 0;
	this.commands = null;
	this.compressor = null;
	this.connectedPeers = 0;
	this.continueSending = 0;
	this.dispatchQueue = null;
	this.headerFlags = null;
	this.incomingBandwidth = 0;
	this.intercept = null;
	this.mtu = 0;
	this.outgoingBandwidth = 0;
	this.packetData = null;
	this.packetSize = 0;
	this.peerCount = 0;
	this.peers = null;
	this.randomSeed = 0;
	this.recalculateBandwidthLimits = 0;
	this.receivedAddress = null;
	this.receivedData = null;
	this.receivedDataLength = 0;
	this.serviceTime = 0;
	this.socket = null;
	this.totalReceivedData = 0;
	this.totalReceivedPackets = 0;
	this.totalSentData = 0;
	this.totalSentPackets = 0;
	this.address = new ENetAddress();
	this.commands = new Array(32);
	for (var i = 0; i < 32; i++) {
		this.commands[i] = new ENetProtocol();
	}
	this.buffers = new Array(65);
	for (var i = 0; i < 65; i++) {
		this.buffers[i] = new ENetBuffer();
	}
	for (var i = 0; i < 65; i++) {
		this.buffers[i] = new ENetBuffer();
	}
	this.dispatchQueue = new ENetPeer();
	this.packetData = new Array(2);
	this.packetData[0] = new Uint8Array(new ArrayBuffer(4096));
	this.packetData[1] = new Uint8Array(new ArrayBuffer(4096));
}
ENetHost.BUFFERS_MAX_COUNT = 65;
ENetHost.COMMANDS_MAX_COUNT = 32;
ENetHost.PACKET_DATA0_SIZE_OF = 4096;

function ENetIncomingCommand()
{
	this.command = null;
	this.fragmentCount = 0;
	this.fragments = null;
	this.fragmentsRemaining = 0;
	this.packet = null;
	this.reliableSequenceNumber = null;
	this.unreliableSequenceNumber = null;
}
ENetIncomingCommand.prototype = new ENetListNode();

ENetIncomingCommand.prototype.incomingCommandList = function() {
	return this;
}

function ENetInterceptCallback()
{
}

function ENetList()
{
	this.setSentinel(new ENetListNode());
}
ENetList.prototype = new ENetListNode();

ENetList.prototype.getSentinel = function() {
	return this.next;
}

ENetList.prototype.setSentinel = function(value) {
	this.next = value;
}

function ENetOutgoingCommand()
{
	this.command = null;
	this.fragmentLength = null;
	this.fragmentOffset = 0;
	this.packet = null;
	this.reliableSequenceNumber = null;
	this.roundTripTimeout = 0;
	this.roundTripTimeoutLimit = 0;
	this.sendAttempts = null;
	this.sentTime = 0;
	this.unreliableSequenceNumber = null;
}
ENetOutgoingCommand.prototype = new ENetListNode();

ENetOutgoingCommand.prototype.outgoingCommandList = function() {
	return this;
}

function ENetPacket()
{
	this.data = null;
	this.dataLength = 0;
	this.flags = 0;
	this.freeCallback = null;
	this.referenceCount = 0;
	this.userData = null;
}

ENetPacket.prototype.getData = function() {
	return this.data;
}

ENetPacket.prototype.getDataLength = function() {
	return this.dataLength;
}

ENetPacket.prototype.getFlags = function() {
	return this.flags;
}

ENetPacket.prototype.getFreeCallback = function() {
	return this.freeCallback;
}

ENetPacket.prototype.getReferenceCount = function() {
	return this.referenceCount;
}

ENetPacket.prototype.getUserData = function() {
	return this.userData;
}

ENetPacket.prototype.setData = function(value) {
	this.data = value;
}

ENetPacket.prototype.setDataLength = function(value) {
	this.dataLength = value;
}

ENetPacket.prototype.setFlags = function(value) {
	this.flags = value;
}

ENetPacket.prototype.setFreeCallback = function(value) {
	this.freeCallback = value;
}

ENetPacket.prototype.setReferenceCount = function(value) {
	this.referenceCount = value;
}

ENetPacket.prototype.setUserData = function(value) {
	this.userData = value;
}

function ENetPacketFlagEnum()
{
}
ENetPacketFlagEnum.E_N_E_T__P_A_C_K_E_T__F_L_A_G__N_O__A_L_L_O_C_A_T_E = 4;
ENetPacketFlagEnum.E_N_E_T__P_A_C_K_E_T__F_L_A_G__R_E_L_I_A_B_L_E = 1;
ENetPacketFlagEnum.E_N_E_T__P_A_C_K_E_T__F_L_A_G__S_E_N_T = 256;
ENetPacketFlagEnum.E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T = 8;
ENetPacketFlagEnum.E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D = 2;

function ENetPacketFreeCallback()
{
}

function ENetPeer()
{
	this.acknowledgements = null;
	this.address = null;
	this.channelCount = 0;
	this.channels = null;
	this.connectID = 0;
	this.data = null;
	this.dispatchedCommands = null;
	this.earliestTimeout = 0;
	this.eventData = 0;
	this.highestRoundTripTimeVariance = 0;
	this.host = null;
	this.incomingBandwidth = 0;
	this.incomingBandwidthThrottleEpoch = 0;
	this.incomingDataTotal = 0;
	this.incomingPeerID = null;
	this.incomingSessionID = 0;
	this.incomingUnsequencedGroup = 0;
	this.lastReceiveTime = 0;
	this.lastRoundTripTime = 0;
	this.lastRoundTripTimeVariance = 0;
	this.lastSendTime = 0;
	this.lowestRoundTripTime = 0;
	this.mtu = 0;
	this.needsDispatch = 0;
	this.nextTimeout = 0;
	this.outgoingBandwidth = 0;
	this.outgoingBandwidthThrottleEpoch = 0;
	this.outgoingDataTotal = 0;
	this.outgoingPeerID = null;
	this.outgoingReliableCommands = null;
	this.outgoingReliableSequenceNumber = null;
	this.outgoingSessionID = 0;
	this.outgoingUnreliableCommands = null;
	this.outgoingUnsequencedGroup = null;
	this.packetLoss = 0;
	this.packetLossEpoch = 0;
	this.packetLossVariance = 0;
	this.packetThrottle = 0;
	this.packetThrottleAcceleration = 0;
	this.packetThrottleCounter = 0;
	this.packetThrottleDeceleration = 0;
	this.packetThrottleEpoch = 0;
	this.packetThrottleInterval = 0;
	this.packetThrottleLimit = 0;
	this.packetsLost = 0;
	this.packetsSent = 0;
	this.pingInterval = 0;
	this.reliableDataInTransit = 0;
	this.roundTripTime = 0;
	this.roundTripTimeVariance = 0;
	this.sentReliableCommands = null;
	this.sentUnreliableCommands = null;
	this.state = 0;
	this.timeoutLimit = 0;
	this.timeoutMaximum = 0;
	this.timeoutMinimum = 0;
	this.unsequencedWindow = null;
	this.windowSize = 0;
	this.acknowledgements = new ENetList();
	this.sentReliableCommands = new ENetList();
	this.sentUnreliableCommands = new ENetList();
	this.outgoingReliableCommands = new ENetList();
	this.outgoingUnreliableCommands = new ENetList();
	this.dispatchedCommands = new ENetList();
	this.unsequencedWindow = new Int32Array(new ArrayBuffer(32 << 2));
}
ENetPeer.prototype = new ENetList();

ENetPeer.prototype.dispatchList = function() {
	return this;
}
ENetPeer.UNSEQUENCED_WINDOW_LENGTH = 32;

function ENetPeerState()
{
}
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__C_O_N_N_E_C_T = 2;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__D_I_S_C_O_N_N_E_C_T = 8;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_E_D = 5;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_N_G = 1;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__P_E_N_D_I_N_G = 3;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__S_U_C_C_E_E_D_E_D = 4;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_E_D = 0;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_I_N_G = 7;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T__L_A_T_E_R = 6;
ENetPeerState.E_N_E_T__P_E_E_R__S_T_A_T_E__Z_O_M_B_I_E = 9;

function ENetPlatform()
{
}

function ENetProtocol()
{
	this.acknowledge = null;
	this.bandwidthLimit = null;
	this.connect = null;
	this.data = null;
	this.disconnect = null;
	this.header = null;
	this.ping = null;
	this.sendFragment = null;
	this.sendReliable = null;
	this.sendUnreliable = null;
	this.sendUnsequenced = null;
	this.throttleConfigure = null;
	this.verifyConnect = null;
	this.header = new ENetProtocolCommandHeader();
}

function ENetProtocolAcknowledge()
{
	this.receivedReliableSequenceNumber = null;
	this.receivedSentTime = null;
}
ENetProtocolAcknowledge.SIZE_OF = 8;

function ENetProtocolBandwidthLimit()
{
	this.incomingBandwidth = 0;
	this.outgoingBandwidth = 0;
}

function ENetProtocolCommandHeader()
{
	this.channelID = 0;
	this.command = 0;
	this.reliableSequenceNumber = null;
}
ENetProtocolCommandHeader.SIZE_OF = 4;

function ENetProtocolConnect()
{
	this.channelCount = 0;
	this.connectID = 0;
	this.data = 0;
	this.incomingBandwidth = 0;
	this.incomingSessionID = 0;
	this.mtu = 0;
	this.outgoingBandwidth = 0;
	this.outgoingPeerID = null;
	this.outgoingSessionID = 0;
	this.packetThrottleAcceleration = 0;
	this.packetThrottleDeceleration = 0;
	this.packetThrottleInterval = 0;
	this.windowSize = 0;
}

function ENetProtocolDisconnect()
{
	this.data = 0;
}

function ENetProtocolHeader()
{
	this.peerID = null;
	this.sentTime = null;
}
ENetProtocolHeader.SIZE_OF = 4;

function ENetProtocolPing()
{
}
ENetProtocolPing.SIZE_OF = 4;

function ENetProtocolSendFragment()
{
	this.dataLength = null;
	this.fragmentCount = 0;
	this.fragmentNumber = 0;
	this.fragmentOffset = 0;
	this.startSequenceNumber = null;
	this.totalLength = 0;
}
ENetProtocolSendFragment.SIZE_OF = 28;

function ENetProtocolSendReliable()
{
	this.dataLength = null;
}
ENetProtocolSendReliable.SIZE_OF = 6;

function ENetProtocolSendUnreliable()
{
	this.dataLength = null;
	this.unreliableSequenceNumber = null;
}
ENetProtocolSendUnreliable.SIZE_OF = 12;

function ENetProtocolSendUnsequenced()
{
	this.dataLength = null;
	this.unsequencedGroup = null;
}

function ENetProtocolThrottleConfigure()
{
	this.packetThrottleAcceleration = 0;
	this.packetThrottleDeceleration = 0;
	this.packetThrottleInterval = 0;
}

function ENetProtocolVerifyConnect()
{
	this.channelCount = 0;
	this.connectID = 0;
	this.incomingBandwidth = 0;
	this.incomingSessionID = 0;
	this.mtu = 0;
	this.outgoingBandwidth = 0;
	this.outgoingPeerID = null;
	this.outgoingSessionID = 0;
	this.packetThrottleAcceleration = 0;
	this.packetThrottleDeceleration = 0;
	this.packetThrottleInterval = 0;
	this.windowSize = 0;
}

function ENetSocket()
{
}

function ENetSocketOption()
{
}
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__B_R_O_A_D_C_A_S_T = 2;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__E_R_R_O_R = 8;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__N_O_D_E_L_A_Y = 9;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__N_O_N_B_L_O_C_K = 1;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__R_C_V_B_U_F = 3;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__R_C_V_T_I_M_E_O = 6;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__R_E_U_S_E_A_D_D_R = 5;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__S_N_D_B_U_F = 4;
ENetSocketOption.E_N_E_T__S_O_C_K_O_P_T__S_N_D_T_I_M_E_O = 7;

function ENetSocketShutdown()
{
}
ENetSocketShutdown.E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D = 0;
ENetSocketShutdown.E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D__W_R_I_T_E = 2;
ENetSocketShutdown.E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__W_R_I_T_E = 1;

function ENetSocketTypeEnum()
{
}
ENetSocketTypeEnum.E_N_E_T__S_O_C_K_E_T__T_Y_P_E__D_A_T_A_G_R_A_M = 2;
ENetSocketTypeEnum.E_N_E_T__S_O_C_K_E_T__T_Y_P_E__S_T_R_E_A_M = 1;

function ENetSymbol()
{
	this.count = 0;
	this.escapes = 0;
	this.left = 0;
	this.parent = 0;
	this.right = 0;
	this.symbols = 0;
	this.total = 0;
	this.under = 0;
	this.value = 0;
}

function Math()
{
}

Math.isLessThanUnsigned = function(n1, n2) {
	var comp = n1 < n2;
	if (n1 < 0 != n2 < 0) {
		comp = !comp;
	}
	return comp;
}

function UserData()
{
}
