// Generated automatically with "cito". Do not edit.
#include <stdlib.h>
#include <string.h>
#include "EnetCito.h"

struct Byte {
	unsigned char value;
};

struct ENet {
	bool initializedCRC32;
	int test1;
	int *commandSizes;
	int *crcTable;
	ENetIncomingCommand const *dummyCommand;
	ENetPlatform const *p;
};
static void ENet_Construct(ENet *self);
static ENetProtocolHeader const *ENet_Deserialize(ENet const *self, unsigned char const *a);
static void ENet_DeserializeProtocolCommandCommand(ENet const *self, unsigned char const *readBuf, int currentDataI, unsigned char commandNumber, ENetProtocol *command);
static ENetProtocol *ENet_DeserializeProtocolCommandHeader(ENet const *self, unsigned char const *currentData, int currentDataI);
static ushort ENet_ENET_HOST_TO_NET_16(ENet const *self, ushort a);
static int ENet_ENET_MAX(ENet const *self, int x, int y);
static int ENet_ENET_MIN(ENet const *self, int x, int y);
static ushort ENet_ENET_NET_TO_HOST_16(ENet const *self, ushort a);
static int ENet_ENET_NET_TO_HOST_32(ENet const *self, int a);
static int ENet_ENET_TIME_DIFFERENCE(ENet const *self, int a, int b);
static bool ENet_ENET_TIME_GREATER_EQUAL(ENet const *self, int a, int b);
static bool ENet_ENET_TIME_LESS(ENet const *self, int a, int b);
static unsigned char ENet_ReadByte(ENet const *self, unsigned char const *currentData, int currentDataI);
static int ENet_ReadInt(ENet const *self, unsigned char const *readBuf, int readPos);
static ushort ENet_ReadShort(ENet const *self, unsigned char const *readBuf, int readPos);
static void ENet_SerializeCommand(ENet const *self, unsigned char *buf, ENetProtocol const *a);
static void ENet_SerializeHeader(ENet const *self, unsigned char *headerData, ENetProtocolHeader const *header);
static int ENet_ToUint16(ENet const *self, int a);
static void ENet_WriteByte(ENet const *self, unsigned char *data, int *pos, int value);
static void ENet_WriteInt(ENet const *self, unsigned char *data, int *pos, int n);
static void ENet_WriteShort(ENet const *self, unsigned char *data, int *pos, int value);
static int ENet_commandError(ENet const *self, ENetEvent const *event_);
static void ENet_enet_host_bandwidth_throttle(ENet const *self, ENetHost *host);
static ENetListNode *ENet_enet_list_begin(ENet const *self, ENetList const *list);
static void ENet_enet_list_clear(ENet const *self, ENetList const *list);
static bool ENet_enet_list_empty(ENet const *self, ENetList const *list);
static ENetListNode *ENet_enet_list_end(ENet const *self, ENetList const *list);
static ENetListNode const *ENet_enet_list_front(ENet const *self, ENetList const *list);
static ENetListNode const *ENet_enet_list_insert(ENet const *self, ENetListNode *position, ENetObject const *data);
static ENetListNode const *ENet_enet_list_move(ENet const *self, ENetListNode *position, ENetListNode *dataFirst, ENetListNode *dataLast);
static ENetListNode *ENet_enet_list_next(ENet const *self, ENetListNode const *iterator);
static ENetListNode *ENet_enet_list_previous(ENet const *self, ENetListNode const *iterator);
static ENetListNode *ENet_enet_list_remove(ENet const *self, ENetListNode const *position);
static void ENet_enet_peer_dispatch_incoming_reliable_commands(ENet const *self, ENetPeer *peer, ENetChannel *channel);
static void ENet_enet_peer_dispatch_incoming_unreliable_commands(ENet const *self, ENetPeer *peer, ENetChannel *channel);
static void ENet_enet_peer_on_connect(ENet const *self, ENetPeer const *peer);
static void ENet_enet_peer_on_disconnect(ENet const *self, ENetPeer const *peer);
static ENetAcknowledgement const *ENet_enet_peer_queue_acknowledgement(ENet const *self, ENetPeer *peer, ENetProtocol const *command, ushort sentTime);
static ENetIncomingCommand *ENet_enet_peer_queue_incoming_command(ENet const *self, ENetPeer *peer, ENetProtocol const *command, ENetPacket *packet, int fragmentCount);
static ENetOutgoingCommand const *ENet_enet_peer_queue_outgoing_command(ENet const *self, ENetPeer *peer, ENetProtocol *command, ENetPacket *packet, int offset, ushort length);
static int ENet_enet_peer_throttle(ENet const *self, ENetPeer *peer, int rtt);
static int ENet_enet_protocol_command_size(ENet const *self, unsigned char commandNumber);
static int ENet_enet_protocol_handle_send_reliable(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol *command, unsigned char const *currentData, int *currentDataI);
static void ENet_enet_protocol_send_acknowledgements(ENet const *self, ENetHost *host, ENetPeer *peer);
static ENetIncomingCommand const *ENet_freePacket(ENet const *self, int fragmentCount, ENetPacket *packet);
static void ENet_initialize_crc32(ENet *self);
static void ENet_memcpy(ENet const *self, unsigned char *destination, unsigned char const *source, int num);
static ENetIncomingCommand const *ENet_notifyError(ENet const *self, ENetPacket *packet);
static int ENet_reflect_crc(int val, int bits);


struct ENetListNode {
	ENetObject base;
	ENetObject const *data;
	ENetObject const *next;
	ENetObject const *previous;
};

struct ENetAcknowledgement {
	ENetListNode base;
	int sentTime;
	ENetProtocol const *command;
};

struct ENetAddress {
	int host;
	int port;
};

struct ENetBuffer {
	int dataLength;
	unsigned char *data;
};

struct ENetChannel {
	int incomingReliableSequenceNumber;
	int incomingUnreliableSequenceNumber;
	int usedReliableWindows;
	ENetList const *incomingReliableCommands;
	ENetList const *incomingUnreliableCommands;
	ushort outgoingReliableSequenceNumber;
	ushort outgoingUnreliableSequenceNumber;
	int *reliableWindows;
};
static void ENetChannel_Construct(ENetChannel *self);

typedef struct {
	int (*run)(ENetChecksumCallback *self, ENetBuffer const *buffers, int bufferCount);
}
ENetChecksumCallbackVtbl;
struct ENetChecksumCallback {
	const ENetChecksumCallbackVtbl *vtbl;
};
static void ENetChecksumCallback_Construct(ENetChecksumCallback *self, const ENetChecksumCallbackVtbl *vtbl);

typedef struct {
	int (*compress)(ENetCompressor *self, ENetBuffer const *inBuffers, int inBufferCount, int inLimit, unsigned char const *outData, int outLimit);
	int (*decompress)(ENetCompressor *self, unsigned char const *inData, int inLimit, unsigned char const *outData, int outLimit);
	void (*destroy)(ENetCompressor *self);
}
ENetCompressorVtbl;
struct ENetCompressor {
	const ENetCompressorVtbl *vtbl;
};
static void ENetCompressor_Construct(ENetCompressor *self, const ENetCompressorVtbl *vtbl);


struct ENetEvent {
	unsigned char channelID;
	int data;
	ENetEventType type;
	ENetPacket const *packet;
	ENetPeer const *peer;
};

struct ENetHost {
	int bandwidthLimitedPeers;
	int bandwidthThrottleEpoch;
	int bufferCount;
	int channelLimit;
	int commandCount;
	int connectedPeers;
	int continueSending;
	int incomingBandwidth;
	int mtu;
	int outgoingBandwidth;
	int packetSize;
	int peerCount;
	int randomSeed;
	int recalculateBandwidthLimits;
	int receivedDataLength;
	int serviceTime;
	int totalReceivedData;
	int totalReceivedPackets;
	int totalSentData;
	int totalSentPackets;
	ENetAddress const *address;
	ENetBuffer **buffers;
	ENetChecksumCallback const *checksum;
	ENetProtocol **commands;
	ENetCompressor const *compressor;
	ENetList *dispatchQueue;
	ushort headerFlags;
	ENetInterceptCallback const *intercept;
	unsigned char **packetData;
	ENetPeer **peers;
	ENetAddress *receivedAddress;
	unsigned char *receivedData;
	ENetSocket const *socket;
};
static void ENetHost_Construct(ENetHost *self);

struct ENetIncomingCommand {
	ENetListNode base;
	int fragmentCount;
	int fragmentsRemaining;
	ENetProtocol const *command;
	int *fragments;
	ENetPacket *packet;
	ushort reliableSequenceNumber;
	ushort unreliableSequenceNumber;
};

typedef struct {
	int (*run)(ENetInterceptCallback *self, ENetHost const *host, ENetEvent const *event_);
}
ENetInterceptCallbackVtbl;
struct ENetInterceptCallback {
	const ENetInterceptCallbackVtbl *vtbl;
};
static void ENetInterceptCallback_Construct(ENetInterceptCallback *self, const ENetInterceptCallbackVtbl *vtbl);

struct ENetList {
	ENetListNode base;
};
static void ENetList_Construct(ENetList *self);

struct ENetOutgoingCommand {
	ENetListNode base;
	int fragmentOffset;
	int roundTripTimeout;
	int roundTripTimeoutLimit;
	int sentTime;
	ENetProtocol *command;
	ushort fragmentLength;
	ENetPacket *packet;
	ushort reliableSequenceNumber;
	ushort sendAttempts;
	ushort unreliableSequenceNumber;
};

struct ENetPacket {
	int dataLength;
	/**
	 * &lt; internal use only
	 */
	int flags;
	int referenceCount;
	unsigned char *data;
	ENetPacketFreeCallback const *freeCallback;
	UserData const *userData;
};


typedef struct {
	void (*run)(ENetPacketFreeCallback *self, ENetPacket const *packet);
}
ENetPacketFreeCallbackVtbl;
struct ENetPacketFreeCallback {
	const ENetPacketFreeCallbackVtbl *vtbl;
};
static void ENetPacketFreeCallback_Construct(ENetPacketFreeCallback *self, const ENetPacketFreeCallbackVtbl *vtbl);

struct ENetPeer {
	ENetList base;
	unsigned char incomingSessionID;
	unsigned char outgoingSessionID;
	int channelCount;
	int connectID;
	int earliestTimeout;
	int eventData;
	int highestRoundTripTimeVariance;
	int incomingBandwidth;
	int incomingBandwidthThrottleEpoch;
	int incomingDataTotal;
	int incomingUnsequencedGroup;
	int lastReceiveTime;
	int lastRoundTripTime;
	int lastRoundTripTimeVariance;
	int lastSendTime;
	int lowestRoundTripTime;
	int mtu;
	int needsDispatch;
	int nextTimeout;
	int outgoingBandwidth;
	int outgoingBandwidthThrottleEpoch;
	int outgoingDataTotal;
	int packetLoss;
	int packetLossEpoch;
	int packetLossVariance;
	int packetThrottle;
	int packetThrottleAcceleration;
	int packetThrottleCounter;
	int packetThrottleDeceleration;
	int packetThrottleEpoch;
	int packetThrottleInterval;
	int packetThrottleLimit;
	int packetsLost;
	int packetsSent;
	int pingInterval;
	int reliableDataInTransit;
	int roundTripTime;
	int roundTripTimeVariance;
	int state;
	int timeoutLimit;
	int timeoutMaximum;
	int timeoutMinimum;
	int windowSize;
	ENetList const *acknowledgements;
	ENetAddress *address;
	ENetChannel **channels;
	unsigned char const *data;
	ENetList const *dispatchedCommands;
	ENetHost *host;
	ushort incomingPeerID;
	ushort outgoingPeerID;
	ENetList const *outgoingReliableCommands;
	ushort outgoingReliableSequenceNumber;
	ENetList const *outgoingUnreliableCommands;
	ushort outgoingUnsequencedGroup;
	ENetList const *sentReliableCommands;
	ENetList const *sentUnreliableCommands;
	int *unsequencedWindow;
};
static void ENetPeer_Construct(ENetPeer *self);
static ENetListNode const *ENetPeer_dispatchList(ENetPeer const *self);


typedef struct {
	ENetAcknowledgement *(*castToENetAcknowledgement)(ENetPlatform *self, ENetListNode const *a);
	ENetIncomingCommand *(*castToENetIncomingCommand)(ENetPlatform *self, ENetObject const *a);
	ENetListNode *(*castToENetListNode)(ENetPlatform *self, ENetObject const *a);
	ENetOutgoingCommand *(*castToENetOutgoingCommand)(ENetPlatform *self, ENetObject const *a);
	ENetPeer *(*castToENetPeer)(ENetPlatform *self, ENetListNode const *a);
	ushort (*eNET_HOST_TO_NET_16)(ENetPlatform *self, ushort p);
	int (*eNET_HOST_TO_NET_32)(ENetPlatform *self, int p);
	ushort (*eNET_NET_TO_HOST_16)(ENetPlatform *self, ushort p);
	int (*eNET_NET_TO_HOST_32)(ENetPlatform *self, int fragmentOffset);
	ushort (*intToUshort)(ENetPlatform *self, int p);
	int (*enet_address_set_host)(ENetPlatform *self, ENetAddress const *address, const char *hostName);
	int (*enet_socket_accept)(ENetPlatform *self, ENetSocket const *socket, ENetAddress const *address);
	int (*enet_socket_bind)(ENetPlatform *self, ENetSocket const *socket, ENetAddress const *address);
	int (*enet_socket_connect)(ENetPlatform *self, ENetSocket const *socket, ENetAddress const *address);
	ENetSocket const *(*enet_socket_create)(ENetPlatform *self, int type);
	void (*enet_socket_destroy)(ENetPlatform *self, ENetSocket const *socket);
	int (*enet_socket_get_address)(ENetPlatform *self, ENetSocket const *socket, ENetAddress const *address);
	int (*enet_socket_listen)(ENetPlatform *self, ENetSocket const *socket, int backlog);
	int (*enet_socket_receive)(ENetPlatform *self, ENetSocket const *socket, ENetAddress const *address, ENetBuffer const *const *buffers, int bufferCount);
	int (*enet_socket_send)(ENetPlatform *self, ENetSocket const *socket, ENetAddress const *address, ENetBuffer const *const *buffers, int bufferCount);
	int (*enet_socket_set_option)(ENetPlatform *self, ENetSocket const *socket, int option, int value);
	int (*enet_socket_shutdown)(ENetPlatform *self, ENetSocket const *socket, ENetSocketShutdown const *how);
	int (*enet_socket_wait)(ENetPlatform *self, ENetSocket const *socket, int const *condition, int timeout);
	int (*enet_time_get)(ENetPlatform *self);
	int (*time)(ENetPlatform *self);
}
ENetPlatformVtbl;
struct ENetPlatform {
	const ENetPlatformVtbl *vtbl;
};
static void ENetPlatform_Construct(ENetPlatform *self, const ENetPlatformVtbl *vtbl);

struct ENetProtocol {
	ENetProtocolAcknowledge *acknowledge;
	ENetProtocolBandwidthLimit *bandwidthLimit;
	ENetProtocolConnect *connect;
	unsigned char *data;
	ENetProtocolDisconnect *disconnect;
	ENetProtocolCommandHeader *header;
	ENetProtocolPing const *ping;
	ENetProtocolSendFragment *sendFragment;
	ENetProtocolSendReliable *sendReliable;
	ENetProtocolSendUnreliable *sendUnreliable;
	ENetProtocolSendUnsequenced *sendUnsequenced;
	ENetProtocolThrottleConfigure *throttleConfigure;
	ENetProtocolVerifyConnect *verifyConnect;
};
static void ENetProtocol_Construct(ENetProtocol *self);

struct ENetProtocolAcknowledge {
	ushort receivedReliableSequenceNumber;
	ushort receivedSentTime;
};

struct ENetProtocolBandwidthLimit {
	int incomingBandwidth;
	int outgoingBandwidth;
};

struct ENetProtocolCommandHeader {
	unsigned char channelID;
	unsigned char command;
	ushort reliableSequenceNumber;
};

struct ENetProtocolConnect {
	unsigned char incomingSessionID;
	unsigned char outgoingSessionID;
	int channelCount;
	int connectID;
	int data;
	int incomingBandwidth;
	int mtu;
	int outgoingBandwidth;
	int packetThrottleAcceleration;
	int packetThrottleDeceleration;
	int packetThrottleInterval;
	int windowSize;
	ushort outgoingPeerID;
};

struct ENetProtocolDisconnect {
	int data;
};

struct ENetProtocolHeader {
	ushort peerID;
	ushort sentTime;
};


struct ENetProtocolSendFragment {
	int fragmentCount;
	int fragmentNumber;
	int fragmentOffset;
	int totalLength;
	ushort dataLength;
	ushort startSequenceNumber;
};

struct ENetProtocolSendReliable {
	ushort dataLength;
};

struct ENetProtocolSendUnreliable {
	ushort dataLength;
	ushort unreliableSequenceNumber;
};

struct ENetProtocolSendUnsequenced {
	ushort dataLength;
	ushort unsequencedGroup;
};

struct ENetProtocolThrottleConfigure {
	int packetThrottleAcceleration;
	int packetThrottleDeceleration;
	int packetThrottleInterval;
};

struct ENetProtocolVerifyConnect {
	unsigned char incomingSessionID;
	unsigned char outgoingSessionID;
	int channelCount;
	int connectID;
	int incomingBandwidth;
	int mtu;
	int outgoingBandwidth;
	int packetThrottleAcceleration;
	int packetThrottleDeceleration;
	int packetThrottleInterval;
	int windowSize;
	ushort outgoingPeerID;
};

typedef struct {
	bool (*nULL)(ENetSocket *self);
}
ENetSocketVtbl;
struct ENetSocket {
	const ENetSocketVtbl *vtbl;
};
static void ENetSocket_Construct(ENetSocket *self, const ENetSocketVtbl *vtbl);




struct ENetSymbol {
	unsigned char count;
	unsigned char value;
	int escapes;
	int left;
	int parent;
	int right;
	int symbols;
	int total;
	int under;
};



Byte *Byte_New(void)
{
	Byte *self = (Byte *) malloc(sizeof(Byte));
	return self;
}

void Byte_Delete(Byte *self)
{
	free(self);
}

static void ENet_Construct(ENet *self)
{
	self->dummyCommand = ENetIncomingCommand_New();
	self->commandSizes = (int *) malloc(13 * sizeof(int ));
	self->commandSizes[0] = 0;
	self->commandSizes[1] = 8;
	self->commandSizes[2] = 48;
	self->commandSizes[3] = 44;
	self->commandSizes[4] = 8;
	self->commandSizes[5] = 4;
	self->commandSizes[6] = 6;
	self->commandSizes[7] = 8;
	self->commandSizes[8] = 24;
	self->commandSizes[9] = 8;
	self->commandSizes[10] = 12;
	self->commandSizes[11] = 16;
	self->commandSizes[12] = 24;
}

ENet *ENet_New(void)
{
	ENet *self = (ENet *) malloc(sizeof(ENet));
	if (self != NULL)
		ENet_Construct(self);
	return self;
}

void ENet_Delete(ENet *self)
{
	free(self);
}

static ENetProtocolHeader const *ENet_Deserialize(ENet const *self, unsigned char const *a)
{
	ENetProtocolHeader *h = ENetProtocolHeader_New();
	h->peerID = ENet_ReadShort(self, a, 0);
	h->sentTime = ENet_ReadShort(self, a, 2);
	return h;
}

static void ENet_DeserializeProtocolCommandCommand(ENet const *self, unsigned char const *readBuf, int currentDataI, unsigned char commandNumber, ENetProtocol *command)
{
	int pos = currentDataI + 4;
	switch (commandNumber) {
	case 1:
		command->acknowledge = ENetProtocolAcknowledge_New();
		command->acknowledge->receivedReliableSequenceNumber = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->acknowledge->receivedSentTime = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		break;
	case 2:
		command->connect = ENetProtocolConnect_New();
		command->connect->outgoingPeerID = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->connect->incomingSessionID = ENet_ReadByte(self, readBuf, pos);
		pos += 1;
		command->connect->outgoingSessionID = ENet_ReadByte(self, readBuf, pos);
		pos += 1;
		command->connect->mtu = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->windowSize = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->channelCount = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->incomingBandwidth = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->outgoingBandwidth = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->packetThrottleInterval = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->packetThrottleAcceleration = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->packetThrottleDeceleration = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->connectID = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->connect->data = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	case 3:
		command->verifyConnect = ENetProtocolVerifyConnect_New();
		command->verifyConnect->outgoingPeerID = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->verifyConnect->incomingSessionID = ENet_ReadByte(self, readBuf, pos);
		pos += 1;
		command->verifyConnect->outgoingSessionID = ENet_ReadByte(self, readBuf, pos);
		pos += 1;
		command->verifyConnect->mtu = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->windowSize = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->channelCount = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->incomingBandwidth = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->outgoingBandwidth = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->packetThrottleInterval = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->packetThrottleAcceleration = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->packetThrottleDeceleration = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->verifyConnect->connectID = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	case 4:
		command->disconnect = ENetProtocolDisconnect_New();
		command->disconnect->data = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	case 5:
		command->ping = ENetProtocolPing_New();
		break;
	case 6:
		command->sendReliable = ENetProtocolSendReliable_New();
		command->sendReliable->dataLength = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		break;
	case 7:
		command->sendUnreliable = ENetProtocolSendUnreliable_New();
		command->sendUnreliable->unreliableSequenceNumber = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->sendUnreliable->dataLength = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		break;
	case 9:
		command->sendUnsequenced = ENetProtocolSendUnsequenced_New();
		command->sendUnsequenced->unsequencedGroup = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->sendUnsequenced->dataLength = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		break;
	case 8:
		command->sendFragment = ENetProtocolSendFragment_New();
		command->sendFragment->startSequenceNumber = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->sendFragment->dataLength = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->sendFragment->fragmentCount = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->sendFragment->fragmentNumber = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->sendFragment->totalLength = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->sendFragment->fragmentOffset = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	case 10:
		command->bandwidthLimit = ENetProtocolBandwidthLimit_New();
		command->bandwidthLimit->incomingBandwidth = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->bandwidthLimit->outgoingBandwidth = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	case 11:
		command->throttleConfigure = ENetProtocolThrottleConfigure_New();
		command->throttleConfigure->packetThrottleInterval = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->throttleConfigure->packetThrottleAcceleration = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->throttleConfigure->packetThrottleDeceleration = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	case 12:
		command->sendFragment = ENetProtocolSendFragment_New();
		command->sendFragment->startSequenceNumber = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->sendFragment->dataLength = ENet_ReadShort(self, readBuf, pos);
		pos += 2;
		command->sendFragment->fragmentCount = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->sendFragment->fragmentNumber = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->sendFragment->totalLength = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		command->sendFragment->fragmentOffset = ENet_ReadInt(self, readBuf, pos);
		pos += 4;
		break;
	default:
		break;
	}
}

static ENetProtocol *ENet_DeserializeProtocolCommandHeader(ENet const *self, unsigned char const *currentData, int currentDataI)
{
	int pos = currentDataI;
	ENetProtocol *a = ENetProtocol_New();
	a->header = ENetProtocolCommandHeader_New();
	a->header->command = ENet_ReadByte(self, currentData, pos);
	pos += 1;
	a->header->channelID = ENet_ReadByte(self, currentData, pos);
	pos += 1;
	a->header->reliableSequenceNumber = ENet_ReadShort(self, currentData, pos);
	pos += 2;
	return a;
}

static ushort ENet_ENET_HOST_TO_NET_16(ENet const *self, ushort a)
{
	return self->p->vtbl->eNET_HOST_TO_NET_16(self->p, a);
}

static int ENet_ENET_MAX(ENet const *self, int x, int y)
{
	return x > y ? x : y;
}

static int ENet_ENET_MIN(ENet const *self, int x, int y)
{
	return x < y ? x : y;
}

static ushort ENet_ENET_NET_TO_HOST_16(ENet const *self, ushort a)
{
	return self->p->vtbl->eNET_NET_TO_HOST_16(self->p, a);
}

static int ENet_ENET_NET_TO_HOST_32(ENet const *self, int a)
{
	return self->p->vtbl->eNET_NET_TO_HOST_32(self->p, a);
}

static int ENet_ENET_TIME_DIFFERENCE(ENet const *self, int a, int b)
{
	return a - b < 0 ? b - a : a - b;
}

static bool ENet_ENET_TIME_GREATER_EQUAL(ENet const *self, int a, int b)
{
	return !ENet_ENET_TIME_LESS(self, a, b);
}

static bool ENet_ENET_TIME_LESS(ENet const *self, int a, int b)
{
	return a - b < 0;
}

int ENet_ENET_VERSION(void)
{
	return ENet_ENET_VERSION_CREATE(1, 3, 8);
}

int ENet_ENET_VERSION_CREATE(int major, int minor, int patch)
{
	return (major << 16) | (minor << 8) | patch;
}

int ENet_ENET_VERSION_GET_MAJOR(int version)
{
	return (version >> 16) & 255;
}

int ENet_ENET_VERSION_GET_MINOR(int version)
{
	return (version >> 8) & 255;
}

int ENet_ENET_VERSION_GET_PATCH(int version)
{
	return version & 255;
}

static unsigned char ENet_ReadByte(ENet const *self, unsigned char const *currentData, int currentDataI)
{
	return currentData[currentDataI];
}

static int ENet_ReadInt(ENet const *self, unsigned char const *readBuf, int readPos)
{
	int n = readBuf[readPos + 3] << 24;
	n |= readBuf[readPos + 2] << 16;
	n |= readBuf[readPos + 1] << 8;
	n |= readBuf[readPos + 0];
	return n;
}

static ushort ENet_ReadShort(ENet const *self, unsigned char const *readBuf, int readPos)
{
	int n = readBuf[readPos + 1] << 8;
	n |= readBuf[readPos + 0];
	readPos += 2;
	return self->p->vtbl->intToUshort(self->p, n);
}

static void ENet_SerializeCommand(ENet const *self, unsigned char *buf, ENetProtocol const *a)
{
	if (a == NULL) {
		a = ENetProtocol_New();
	}
	int *pos = (int *) malloc(1 * sizeof(int ));
	pos[0] = 0;
	ENet_WriteByte(self, buf, pos, a->header->command);
	ENet_WriteByte(self, buf, pos, a->header->channelID);
	ENet_WriteShort(self, buf, pos, a->header->reliableSequenceNumber);
	switch (a->header->command & 15) {
	case 1:
		{
			ENet_WriteShort(self, buf, pos, a->acknowledge->receivedReliableSequenceNumber);
			ENet_WriteShort(self, buf, pos, a->acknowledge->receivedSentTime);
			break;
		}
	case 2:
		{
			ENet_WriteShort(self, buf, pos, a->connect->outgoingPeerID);
			ENet_WriteByte(self, buf, pos, a->connect->incomingSessionID);
			ENet_WriteByte(self, buf, pos, a->connect->outgoingSessionID);
			ENet_WriteInt(self, buf, pos, a->connect->mtu);
			ENet_WriteInt(self, buf, pos, a->connect->windowSize);
			ENet_WriteInt(self, buf, pos, a->connect->channelCount);
			ENet_WriteInt(self, buf, pos, a->connect->incomingBandwidth);
			ENet_WriteInt(self, buf, pos, a->connect->outgoingBandwidth);
			ENet_WriteInt(self, buf, pos, a->connect->packetThrottleInterval);
			ENet_WriteInt(self, buf, pos, a->connect->packetThrottleAcceleration);
			ENet_WriteInt(self, buf, pos, a->connect->packetThrottleDeceleration);
			ENet_WriteInt(self, buf, pos, a->connect->connectID);
			ENet_WriteInt(self, buf, pos, a->connect->data);
			break;
		}
	case 3:
		{
			ENet_WriteInt(self, buf, pos, a->connect->outgoingPeerID);
			ENet_WriteByte(self, buf, pos, a->connect->incomingSessionID);
			ENet_WriteByte(self, buf, pos, a->connect->outgoingSessionID);
			ENet_WriteInt(self, buf, pos, a->connect->mtu);
			ENet_WriteInt(self, buf, pos, a->connect->windowSize);
			ENet_WriteInt(self, buf, pos, a->connect->channelCount);
			ENet_WriteInt(self, buf, pos, a->connect->incomingBandwidth);
			ENet_WriteInt(self, buf, pos, a->connect->outgoingBandwidth);
			ENet_WriteInt(self, buf, pos, a->connect->packetThrottleInterval);
			ENet_WriteInt(self, buf, pos, a->connect->packetThrottleAcceleration);
			ENet_WriteInt(self, buf, pos, a->connect->packetThrottleDeceleration);
			ENet_WriteInt(self, buf, pos, a->connect->connectID);
			break;
		}
	case 4:
		{
			ENet_WriteInt(self, buf, pos, a->disconnect->data);
			break;
		}
	case 5:
		{
			break;
		}
	case 6:
		{
			ENet_WriteShort(self, buf, pos, a->sendReliable->dataLength);
			break;
		}
	case 7:
		{
			ENet_WriteShort(self, buf, pos, a->sendUnreliable->unreliableSequenceNumber);
			ENet_WriteShort(self, buf, pos, a->sendUnreliable->dataLength);
			break;
		}
	case 8:
	case 12:
		{
			ENet_WriteShort(self, buf, pos, a->sendFragment->startSequenceNumber);
			ENet_WriteShort(self, buf, pos, a->sendFragment->dataLength);
			ENet_WriteInt(self, buf, pos, a->sendFragment->fragmentCount);
			ENet_WriteInt(self, buf, pos, a->sendFragment->fragmentNumber);
			ENet_WriteInt(self, buf, pos, a->sendFragment->totalLength);
			ENet_WriteInt(self, buf, pos, a->sendFragment->fragmentOffset);
			break;
		}
	case 9:
		{
			ENet_WriteShort(self, buf, pos, a->sendUnsequenced->unsequencedGroup);
			ENet_WriteShort(self, buf, pos, a->sendUnsequenced->dataLength);
			break;
		}
	case 10:
		{
			ENet_WriteInt(self, buf, pos, a->bandwidthLimit->incomingBandwidth);
			ENet_WriteInt(self, buf, pos, a->bandwidthLimit->outgoingBandwidth);
			break;
		}
	case 11:
		{
			ENet_WriteInt(self, buf, pos, a->throttleConfigure->packetThrottleInterval);
			ENet_WriteInt(self, buf, pos, a->throttleConfigure->packetThrottleAcceleration);
			ENet_WriteInt(self, buf, pos, a->throttleConfigure->packetThrottleDeceleration);
			break;
		}
	}
}

static void ENet_SerializeHeader(ENet const *self, unsigned char *headerData, ENetProtocolHeader const *header)
{
	int *pos = (int *) malloc(1 * sizeof(int ));
	pos[0] = 0;
	ENet_WriteShort(self, headerData, pos, header->peerID);
	ENet_WriteShort(self, headerData, pos, header->sentTime);
}

void ENet_SetPlatform(ENet *self, ENetPlatform const *value)
{
	self->p = value;
}

unsigned char ENet_ToByte(int a)
{
	return (unsigned char) a;
}

static int ENet_ToUint16(ENet const *self, int a)
{
	return self->p->vtbl->intToUshort(self->p, a);
}

static void ENet_WriteByte(ENet const *self, unsigned char *data, int *pos, int value)
{
	int pos_ = pos[0];
	data[pos_] = ENet_ToByte(value);
	pos[0] += 1;
}

static void ENet_WriteInt(ENet const *self, unsigned char *data, int *pos, int n)
{
	int pos_ = pos[0];
	data[pos_ + 3] = ENet_ToByte((n >> 24) & 255);
	data[pos_ + 2] = ENet_ToByte((n >> 16) & 255);
	data[pos_ + 1] = ENet_ToByte((n >> 8) & 255);
	data[pos_ + 0] = ENet_ToByte(n & 255);
	pos[0] += 4;
}

static void ENet_WriteShort(ENet const *self, unsigned char *data, int *pos, int value)
{
	int pos_ = pos[0];
	data[pos_] = ENet_ToByte(value & 255);
	data[pos_ + 1] = ENet_ToByte((value >> 8) & 255);
	pos[0] += 2;
}

static int ENet_commandError(ENet const *self, ENetEvent const *event_)
{
	if (event_ != NULL && event_->type != ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
		return 1;
	return 0;
}

int ENet_enet_address_set_host(ENet const *self, ENetAddress const *address, const char *hostName)
{
	return self->p->vtbl->enet_address_set_host(self->p, address, hostName);
}

int ENet_enet_crc32(ENet *self, ENetBuffer const *const *buffers, int bufferCount)
{
	int crc = -1;
	if (!self->initializedCRC32)
		ENet_initialize_crc32(self);
	for (int buf = 0; buf < bufferCount; buf++) {
		unsigned char const *data = buffers[buf]->data;
		int dataLength = buffers[buf]->dataLength;
		for (int i = 0; i < dataLength; i++) {
			crc = (crc >> 8) ^ self->crcTable[(crc & 255) ^ data[i]];
		}
	}
	return self->p->vtbl->eNET_HOST_TO_NET_32(self->p, ~crc);
}

void ENet_enet_deinitialize(ENet const *self)
{
}

void ENet_enet_host_bandwidth_limit(ENet const *self, ENetHost *host, int incomingBandwidth, int outgoingBandwidth)
{
	host->incomingBandwidth = incomingBandwidth;
	host->outgoingBandwidth = outgoingBandwidth;
	host->recalculateBandwidthLimits = 1;
}

static void ENet_enet_host_bandwidth_throttle(ENet const *self, ENetHost *host)
{
	int timeCurrent = self->p->vtbl->enet_time_get(self->p);
	int elapsedTime = timeCurrent - host->bandwidthThrottleEpoch;
	int peersRemaining = host->connectedPeers;
	int dataTotal = ~0;
	int bandwidth = ~0;
	int throttle = 0;
	int bandwidthLimit = 0;
	int needsAdjustment = host->bandwidthLimitedPeers > 0 ? 1 : 0;
	ENetPeer *peer;
	ENetProtocol *command = ENetProtocol_New();
	if (elapsedTime < 1000)
		return;
	host->bandwidthThrottleEpoch = timeCurrent;
	if (peersRemaining == 0)
		return;
	if (host->outgoingBandwidth != 0) {
		dataTotal = 0;
		bandwidth = host->outgoingBandwidth * elapsedTime / 1000;
		for (int i = 0; i < host->peerCount; i++) {
			peer = host->peers[i];
			if (peer->state != 5 && peer->state != 6)
				continue;
			dataTotal += peer->outgoingDataTotal;
		}
	}
	while (peersRemaining > 0 && needsAdjustment != 0) {
		needsAdjustment = 0;
		if (dataTotal <= bandwidth)
			throttle = 32;
		else
			throttle = bandwidth * 32 / dataTotal;
		for (int i = 0; i < host->peerCount; i++) {
			peer = host->peers[i];
			int peerBandwidth;
			if ((peer->state != 5 && peer->state != 6) || peer->incomingBandwidth == 0 || peer->outgoingBandwidthThrottleEpoch == timeCurrent)
				continue;
			peerBandwidth = peer->incomingBandwidth * elapsedTime / 1000;
			if (throttle * peer->outgoingDataTotal / 32 <= peerBandwidth)
				continue;
			peer->packetThrottleLimit = peerBandwidth * 32 / peer->outgoingDataTotal;
			if (peer->packetThrottleLimit == 0)
				peer->packetThrottleLimit = 1;
			if (peer->packetThrottle > peer->packetThrottleLimit)
				peer->packetThrottle = peer->packetThrottleLimit;
			peer->outgoingBandwidthThrottleEpoch = timeCurrent;
			peer->incomingDataTotal = 0;
			peer->outgoingDataTotal = 0;
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
			throttle = bandwidth * 32 / dataTotal;
		for (int i = 0; i < host->peerCount; i++) {
			peer = host->peers[i];
			if ((peer->state != 5 && peer->state != 6) || peer->outgoingBandwidthThrottleEpoch == timeCurrent)
				continue;
			peer->packetThrottleLimit = throttle;
			if (peer->packetThrottle > peer->packetThrottleLimit)
				peer->packetThrottle = peer->packetThrottleLimit;
			peer->incomingDataTotal = 0;
			peer->outgoingDataTotal = 0;
		}
	}
	if (host->recalculateBandwidthLimits != 0) {
		host->recalculateBandwidthLimits = 0;
		peersRemaining = host->connectedPeers;
		bandwidth = host->incomingBandwidth;
		needsAdjustment = 1;
		if (bandwidth == 0)
			bandwidthLimit = 0;
		else
			while (peersRemaining > 0 && needsAdjustment != 0) {
				needsAdjustment = 0;
				bandwidthLimit = bandwidth / peersRemaining;
				for (int i = 0; i < host->peerCount; i++) {
					peer = host->peers[i];
					if ((peer->state != 5 && peer->state != 6) || peer->incomingBandwidthThrottleEpoch == timeCurrent)
						continue;
					if (peer->outgoingBandwidth > 0 && peer->outgoingBandwidth >= bandwidthLimit)
						continue;
					peer->incomingBandwidthThrottleEpoch = timeCurrent;
					needsAdjustment = 1;
					peersRemaining--;
					bandwidth -= peer->outgoingBandwidth;
				}
			}
		for (int i = 0; i < host->peerCount; i++) {
			peer = host->peers[i];
			if (peer->state != 5 && peer->state != 6)
				continue;
			command->header->command = 138;
			command->header->channelID = 255;
			command->bandwidthLimit = ENetProtocolBandwidthLimit_New();
			command->bandwidthLimit->outgoingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, host->outgoingBandwidth);
			if (peer->incomingBandwidthThrottleEpoch == timeCurrent)
				command->bandwidthLimit->incomingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, peer->outgoingBandwidth);
			else
				command->bandwidthLimit->incomingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, bandwidthLimit);
			ENet_enet_peer_queue_outgoing_command(self, peer, command, NULL, 0, 0);
		}
	}
}

void ENet_enet_host_broadcast(ENet const *self, ENetHost const *host, unsigned char channelID, ENetPacket *packet)
{
	ENetPeer *currentPeer;
	for (int i = 0; i < host->peerCount; i++) {
		currentPeer = host->peers[i];
		if (currentPeer->state != 5)
			continue;
		ENet_enet_peer_send(self, currentPeer, channelID, packet);
	}
	if (packet->referenceCount == 0)
		ENet_enet_packet_destroy(self, packet);
}

void ENet_enet_host_channel_limit(ENet const *self, ENetHost *host, int channelLimit)
{
	if (channelLimit == 0 || channelLimit > 255)
		channelLimit = 255;
	else if (channelLimit < 1)
		channelLimit = 1;
	host->channelLimit = channelLimit;
}

int ENet_enet_host_check_events(ENet const *self, ENetHost *host, ENetEvent *event_)
{
	if (event_ == NULL)
		return -1;
	event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E;
	event_->peer = NULL;
	event_->packet = NULL;
	return ENet_enet_protocol_dispatch_incoming_commands(self, host, event_);
}

void ENet_enet_host_compress(ENet const *self, ENetHost *host, ENetCompressor const *compressor)
{
	if (host->compressor != NULL)
		host->compressor->vtbl->destroy(host->compressor);
	if (compressor != NULL)
		host->compressor = compressor;
	else
		host->compressor = NULL;
}

int ENet_enet_host_compress_with_range_coder(ENet const *self, ENetHost const *host)
{
	return 0;
}

ENetPeer const *ENet_enet_host_connect(ENet const *self, ENetHost *host, ENetAddress const *address, int channelCount, int data)
{
	ENetPeer *currentPeer = NULL;
	ENetChannel *channel;
	ENetProtocol *command = ENetProtocol_New();
	if (channelCount < 1)
		channelCount = 1;
	else if (channelCount > 255)
		channelCount = 255;
	for (int i = 0; i < host->peerCount; i++) {
		currentPeer = host->peers[i];
		if (currentPeer->state == 0)
			break;
	}
	if (host->peerCount == 0) {
		return NULL;
	}
	currentPeer->channels = (ENetChannel const **) malloc(channelCount * sizeof(ENetChannel const *));
	for (int i = 0; i < channelCount; i++) {
		currentPeer->channels[i] = ENetChannel_New();
	}
	if (currentPeer->channels == NULL)
		return NULL;
	currentPeer->channelCount = channelCount;
	currentPeer->state = 1;
	currentPeer->address = ENetAddress_Clone(address);
	currentPeer->connectID = ++host->randomSeed;
	if (host->outgoingBandwidth == 0)
		currentPeer->windowSize = 32768;
	else
		currentPeer->windowSize = host->outgoingBandwidth / 65536 * 4096;
	if (currentPeer->windowSize < 4096)
		currentPeer->windowSize = 4096;
	else if (currentPeer->windowSize > 32768)
		currentPeer->windowSize = 32768;
	for (int i = 0; i < channelCount; i++) {
		channel = currentPeer->channels[i];
		channel->outgoingReliableSequenceNumber = 0;
		channel->outgoingUnreliableSequenceNumber = 0;
		channel->incomingReliableSequenceNumber = 0;
		channel->incomingUnreliableSequenceNumber = 0;
		ENet_enet_list_clear(self, channel->incomingReliableCommands);
		ENet_enet_list_clear(self, channel->incomingUnreliableCommands);
		channel->usedReliableWindows = 0;
		for (int k = 0; k < 16; k++) {
			channel->reliableWindows[k] = 0;
		}
	}
	command->header = ENetProtocolCommandHeader_New();
	command->header->command = 130;
	command->header->channelID = 255;
	command->connect = ENetProtocolConnect_New();
	command->connect->outgoingPeerID = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, currentPeer->incomingPeerID);
	command->connect->incomingSessionID = currentPeer->incomingSessionID;
	command->connect->outgoingSessionID = currentPeer->outgoingSessionID;
	command->connect->mtu = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->mtu);
	command->connect->windowSize = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->windowSize);
	command->connect->channelCount = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, channelCount);
	command->connect->incomingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, host->incomingBandwidth);
	command->connect->outgoingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, host->outgoingBandwidth);
	command->connect->packetThrottleInterval = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->packetThrottleInterval);
	command->connect->packetThrottleAcceleration = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->packetThrottleAcceleration);
	command->connect->packetThrottleDeceleration = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->packetThrottleDeceleration);
	command->connect->connectID = currentPeer->connectID;
	command->connect->data = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, data);
	ENet_enet_peer_queue_outgoing_command(self, currentPeer, command, NULL, 0, 0);
	return currentPeer;
}

ENetHost const *ENet_enet_host_create(ENet const *self, ENetAddress const *address, int peerCount, int channelLimit, int incomingBandwidth, int outgoingBandwidth)
{
	ENetHost *host;
	ENetPeer *currentPeer;
	if (peerCount > 4095)
		return NULL;
	host = ENetHost_New();
	if (host == NULL)
		return NULL;
	host->peers = (ENetPeer const **) malloc(peerCount * sizeof(ENetPeer const *));
	if (host->peers == NULL) {
		free(host);
		return NULL;
	}
	for (int i = 0; i < peerCount; i++) {
		host->peers[i] = ENetPeer_New();
	}
	host->socket = self->p->vtbl->enet_socket_create(self->p, 2);
	if ((host->socket != NULL && host->socket->vtbl->nULL(host->socket)) || (address != NULL && self->p->vtbl->enet_socket_bind(self->p, host->socket, address) < 0)) {
		if (host->socket != NULL && !host->socket->vtbl->nULL(host->socket))
			self->p->vtbl->enet_socket_destroy(self->p, host->socket);
		free(host->peers);
		free(host);
		return NULL;
	}
	self->p->vtbl->enet_socket_set_option(self->p, host->socket, 1, 1);
	self->p->vtbl->enet_socket_set_option(self->p, host->socket, 2, 1);
	self->p->vtbl->enet_socket_set_option(self->p, host->socket, 3, 262144);
	self->p->vtbl->enet_socket_set_option(self->p, host->socket, 4, 262144);
	if (address != NULL && self->p->vtbl->enet_socket_get_address(self->p, host->socket, host->address) < 0)
		host->address = address;
	if (channelLimit == 0 || channelLimit > 255)
		channelLimit = 255;
	else if (channelLimit < 1)
		channelLimit = 1;
	host->randomSeed = 0;
	host->randomSeed += self->p->vtbl->time(self->p);
	host->randomSeed = (host->randomSeed << 16) | (host->randomSeed >> 16);
	host->channelLimit = channelLimit;
	host->incomingBandwidth = incomingBandwidth;
	host->outgoingBandwidth = outgoingBandwidth;
	host->bandwidthThrottleEpoch = 0;
	host->recalculateBandwidthLimits = 0;
	host->mtu = 1400;
	host->peerCount = peerCount;
	host->commandCount = 0;
	host->bufferCount = 0;
	host->checksum = NULL;
	host->receivedAddress = ENetAddress_New();
	host->receivedAddress->host = 0;
	host->receivedAddress->port = 0;
	host->receivedData = NULL;
	host->receivedDataLength = 0;
	host->totalSentData = 0;
	host->totalSentPackets = 0;
	host->totalReceivedData = 0;
	host->totalReceivedPackets = 0;
	host->connectedPeers = 0;
	host->bandwidthLimitedPeers = 0;
	host->compressor = NULL;
	host->intercept = NULL;
	host->dispatchQueue = &ENetPeer_New()->base;
	ENetList_SetSentinel(host->dispatchQueue, &ENetPeer_New()->base.base.base);
	ENet_enet_list_clear(self, host->dispatchQueue);
	for (int i = 0; i < host->peerCount; i++) {
		currentPeer = host->peers[i];
		currentPeer->host = host;
		currentPeer->incomingPeerID = self->p->vtbl->intToUshort(self->p, i);
		currentPeer->outgoingSessionID = currentPeer->incomingSessionID = 255;
		currentPeer->data = NULL;
		ENet_enet_list_clear(self, currentPeer->acknowledgements);
		ENet_enet_list_clear(self, currentPeer->sentReliableCommands);
		ENet_enet_list_clear(self, currentPeer->sentUnreliableCommands);
		ENet_enet_list_clear(self, currentPeer->outgoingReliableCommands);
		ENet_enet_list_clear(self, currentPeer->outgoingUnreliableCommands);
		ENet_enet_list_clear(self, currentPeer->dispatchedCommands);
		ENet_enet_peer_reset(self, currentPeer);
	}
	return host;
}

void ENet_enet_host_destroy(ENet const *self, ENetHost *host)
{
	ENetPeer *currentPeer;
	if (host == NULL)
		return;
	self->p->vtbl->enet_socket_destroy(self->p, host->socket);
	for (int i = 0; i < host->peerCount; i++) {
		currentPeer = host->peers[i];
		ENet_enet_peer_reset(self, currentPeer);
	}
	if (host->compressor != NULL)
		host->compressor->vtbl->destroy(host->compressor);
	free(host->peers);
	free(host);
}

void ENet_enet_host_flush(ENet *self, ENetHost *host)
{
	host->serviceTime = self->p->vtbl->enet_time_get(self->p);
	ENet_enet_protocol_send_outgoing_commands(self, host, NULL, 0);
}

int ENet_enet_host_service(ENet *self, ENetHost *host, ENetEvent *event_, int timeout)
{
	int *waitCondition = (int *) malloc(1 * sizeof(int ));
	if (event_ != NULL) {
		event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E;
		event_->peer = NULL;
		event_->packet = NULL;
		switch (ENet_enet_protocol_dispatch_incoming_commands(self, host, event_)) {
		case 1:
			return 1;
		case -1:
			return -1;
		default:
			break;
		}
	}
	host->serviceTime = self->p->vtbl->enet_time_get(self->p);
	timeout += host->serviceTime;
	do {
		if (ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, host->bandwidthThrottleEpoch) >= 1000)
			ENet_enet_host_bandwidth_throttle(self, host);
		switch (ENet_enet_protocol_send_outgoing_commands(self, host, event_, 1)) {
		case 1:
			return 1;
		case -1:
			return -1;
		default:
			break;
		}
		switch (ENet_enet_protocol_receive_incoming_commands(self, host, event_)) {
		case 1:
			return 1;
		case -1:
			return -1;
		default:
			break;
		}
		switch (ENet_enet_protocol_send_outgoing_commands(self, host, event_, 1)) {
		case 1:
			return 1;
		case -1:
			return -1;
		default:
			break;
		}
		if (event_ != NULL) {
			switch (ENet_enet_protocol_dispatch_incoming_commands(self, host, event_)) {
			case 1:
				return 1;
			case -1:
				return -1;
			default:
				break;
			}
		}
		do {
			host->serviceTime = self->p->vtbl->enet_time_get(self->p);
			if (ENet_ENET_TIME_GREATER_EQUAL(self, host->serviceTime, timeout))
				return 0;
			waitCondition[0] = 6;
			if (self->p->vtbl->enet_socket_wait(self->p, host->socket, waitCondition, ENet_ENET_TIME_DIFFERENCE(self, timeout, host->serviceTime)) != 0)
				return -1;
		}
		while ((waitCondition[0] & 4) != 0);
		host->serviceTime = self->p->vtbl->enet_time_get(self->p);
	}
	while ((waitCondition[0] & 2) != 0);
	return 0;
}

int ENet_enet_initialize(ENet const *self)
{
	return 0;
}

static ENetListNode *ENet_enet_list_begin(ENet const *self, ENetList const *list)
{
	return self->p->vtbl->castToENetListNode(self->p, self->p->vtbl->castToENetListNode(self->p, ENetList_GetSentinel(list))->next);
}

static void ENet_enet_list_clear(ENet const *self, ENetList const *list)
{
	self->p->vtbl->castToENetListNode(self->p, ENetList_GetSentinel(list))->next = ENetList_GetSentinel(list);
	self->p->vtbl->castToENetListNode(self->p, ENetList_GetSentinel(list))->previous = ENetList_GetSentinel(list);
}

static bool ENet_enet_list_empty(ENet const *self, ENetList const *list)
{
	return ENet_enet_list_begin(self, list) == ENet_enet_list_end(self, list);
}

static ENetListNode *ENet_enet_list_end(ENet const *self, ENetList const *list)
{
	return self->p->vtbl->castToENetListNode(self->p, ENetList_GetSentinel(list));
}

static ENetListNode const *ENet_enet_list_front(ENet const *self, ENetList const *list)
{
	return self->p->vtbl->castToENetListNode(self->p, self->p->vtbl->castToENetListNode(self->p, ENetList_GetSentinel(list))->next);
}

static ENetListNode const *ENet_enet_list_insert(ENet const *self, ENetListNode *position, ENetObject const *data)
{
	ENetListNode *result = self->p->vtbl->castToENetListNode(self->p, data);
	result->previous = position->previous;
	result->next = &position->base;
	self->p->vtbl->castToENetListNode(self->p, result->previous)->next = &result->base;
	position->previous = &result->base;
	return result;
}

static ENetListNode const *ENet_enet_list_move(ENet const *self, ENetListNode *position, ENetListNode *dataFirst, ENetListNode *dataLast)
{
	ENetListNode *first = dataFirst;
	ENetListNode *last = dataLast;
	self->p->vtbl->castToENetListNode(self->p, first->previous)->next = last->next;
	self->p->vtbl->castToENetListNode(self->p, last->next)->previous = first->previous;
	first->previous = position->previous;
	last->next = &position->base;
	self->p->vtbl->castToENetListNode(self->p, first->previous)->next = &first->base;
	position->previous = &last->base;
	return first;
}

static ENetListNode *ENet_enet_list_next(ENet const *self, ENetListNode const *iterator)
{
	return self->p->vtbl->castToENetListNode(self->p, iterator->next);
}

static ENetListNode *ENet_enet_list_previous(ENet const *self, ENetListNode const *iterator)
{
	return self->p->vtbl->castToENetListNode(self->p, iterator->previous);
}

static ENetListNode *ENet_enet_list_remove(ENet const *self, ENetListNode const *position)
{
	self->p->vtbl->castToENetListNode(self->p, position->previous)->next = position->next;
	self->p->vtbl->castToENetListNode(self->p, position->next)->previous = position->previous;
	return position;
}

ENetPacket *ENet_enet_packet_create(ENet const *self, unsigned char *data, int dataLength, int flags)
{
	ENetPacket *packet = ENetPacket_New();
	if (packet == NULL)
		return NULL;
	if ((flags & 4) != 0)
		packet->data = data;
	else if (dataLength <= 0)
		packet->data = NULL;
	else {
		packet->data = (unsigned char *) malloc(dataLength * sizeof(unsigned char ));
		if (packet->data == NULL) {
			free(packet);
			return NULL;
		}
		if (data != NULL) {
			for (int i = 0; i < dataLength; i++) {
				packet->data[i] = data[i];
			}
		}
	}
	packet->referenceCount = 0;
	packet->flags = flags;
	packet->dataLength = dataLength;
	packet->freeCallback = NULL;
	packet->userData = NULL;
	return packet;
}

void ENet_enet_packet_destroy(ENet const *self, ENetPacket *packet)
{
	if (packet == NULL)
		return;
	if (packet->freeCallback != NULL)
		packet->freeCallback->vtbl->run(packet->freeCallback, packet);
	if ((packet->flags & 4) == 0 && packet->data != NULL) {
		free(packet->data);
	}
	free(packet);
}

int ENet_enet_packet_resize(ENet const *self, ENetPacket *packet, int dataLength)
{
	unsigned char *newData;
	if (dataLength <= packet->dataLength || (packet->flags & 4) != 0) {
		packet->dataLength = dataLength;
		return 0;
	}
	newData = (unsigned char *) malloc(dataLength * sizeof(unsigned char ));
	if (newData == NULL)
		return -1;
	ENet_memcpy(self, newData, packet->data, packet->dataLength);
	free(packet->data);
	packet->data = newData;
	packet->dataLength = dataLength;
	return 0;
}

void ENet_enet_peer_disconnect(ENet *self, ENetPeer *peer, int data)
{
	ENetProtocol *command = ENetProtocol_New();
	if (peer->state == 7 || peer->state == 0 || peer->state == 8 || peer->state == 9)
		return;
	ENet_enet_peer_reset_queues(self, peer);
	command->header->command = 4;
	command->header->channelID = 255;
	command->disconnect->data = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, data);
	if (peer->state == 5 || peer->state == 6)
		command->header->command |= 128;
	else
		command->header->command |= 64;
	ENet_enet_peer_queue_outgoing_command(self, peer, command, NULL, 0, 0);
	if (peer->state == 5 || peer->state == 6) {
		ENet_enet_peer_on_disconnect(self, peer);
		peer->state = 7;
	}
	else {
		ENet_enet_host_flush(self, peer->host);
		ENet_enet_peer_reset(self, peer);
	}
}

void ENet_enet_peer_disconnect_later(ENet *self, ENetPeer *peer, int data)
{
	if ((peer->state == 5 || peer->state == 6) && !(ENet_enet_list_empty(self, peer->outgoingReliableCommands) && ENet_enet_list_empty(self, peer->outgoingUnreliableCommands) && ENet_enet_list_empty(self, peer->sentReliableCommands))) {
		peer->state = 6;
		peer->eventData = data;
	}
	else
		ENet_enet_peer_disconnect(self, peer, data);
}

void ENet_enet_peer_disconnect_now(ENet *self, ENetPeer *peer, int data)
{
	ENetProtocol *command = ENetProtocol_New();
	if (peer->state == 0)
		return;
	if (peer->state != 9 && peer->state != 7) {
		ENet_enet_peer_reset_queues(self, peer);
		command->header->command = 68;
		command->header->channelID = 255;
		command->disconnect->data = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, data);
		ENet_enet_peer_queue_outgoing_command(self, peer, command, NULL, 0, 0);
		ENet_enet_host_flush(self, peer->host);
	}
	ENet_enet_peer_reset(self, peer);
}

static void ENet_enet_peer_dispatch_incoming_reliable_commands(ENet const *self, ENetPeer *peer, ENetChannel *channel)
{
	ENetListNode const *currentCommand;
	for (currentCommand = ENet_enet_list_begin(self, channel->incomingReliableCommands); currentCommand != ENet_enet_list_end(self, channel->incomingReliableCommands); currentCommand = ENet_enet_list_next(self, currentCommand)) {
		ENetIncomingCommand const *incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
		if (incomingCommand->fragmentsRemaining > 0 || incomingCommand->reliableSequenceNumber != self->p->vtbl->intToUshort(self->p, channel->incomingReliableSequenceNumber + 1))
			break;
		channel->incomingReliableSequenceNumber = incomingCommand->reliableSequenceNumber;
		if (incomingCommand->fragmentCount > 0)
			channel->incomingReliableSequenceNumber += incomingCommand->fragmentCount - 1;
	}
	if (currentCommand == ENet_enet_list_begin(self, channel->incomingReliableCommands))
		return;
	channel->incomingUnreliableSequenceNumber = 0;
	ENet_enet_list_move(self, ENet_enet_list_end(self, peer->dispatchedCommands), ENet_enet_list_begin(self, channel->incomingReliableCommands), ENet_enet_list_previous(self, currentCommand));
	if (peer->needsDispatch == 0) {
		ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->host->dispatchQueue), &ENetPeer_dispatchList(peer)->base);
		peer->needsDispatch = 1;
	}
	if (!ENet_enet_list_empty(self, channel->incomingUnreliableCommands))
		ENet_enet_peer_dispatch_incoming_unreliable_commands(self, peer, channel);
}

static void ENet_enet_peer_dispatch_incoming_unreliable_commands(ENet const *self, ENetPeer *peer, ENetChannel *channel)
{
	ENetListNode const *droppedCommand;
	ENetListNode *startCommand;
	ENetListNode *currentCommand;
	for (droppedCommand = startCommand = currentCommand = ENet_enet_list_begin(self, channel->incomingUnreliableCommands); currentCommand != ENet_enet_list_end(self, channel->incomingUnreliableCommands); currentCommand = ENet_enet_list_next(self, currentCommand)) {
		ENetIncomingCommand const *incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
		if ((incomingCommand->command->header->command & 15) == 9)
			continue;
		if (incomingCommand->reliableSequenceNumber == channel->incomingReliableSequenceNumber) {
			if (incomingCommand->fragmentsRemaining <= 0) {
				channel->incomingUnreliableSequenceNumber = incomingCommand->unreliableSequenceNumber;
				continue;
			}
			if (startCommand != currentCommand) {
				ENet_enet_list_move(self, ENet_enet_list_end(self, peer->dispatchedCommands), startCommand, ENet_enet_list_previous(self, currentCommand));
				if (peer->needsDispatch == 0) {
					ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->host->dispatchQueue), &ENetPeer_dispatchList(peer)->base);
					peer->needsDispatch = 1;
				}
				droppedCommand = currentCommand;
			}
			else if (droppedCommand != currentCommand)
				droppedCommand = ENet_enet_list_previous(self, currentCommand);
		}
		else {
			ushort reliableWindow = self->p->vtbl->intToUshort(self->p, incomingCommand->reliableSequenceNumber / 4096);
			ushort currentWindow = self->p->vtbl->intToUshort(self->p, channel->incomingReliableSequenceNumber / 4096);
			if (incomingCommand->reliableSequenceNumber < channel->incomingReliableSequenceNumber)
				reliableWindow += 16;
			if (reliableWindow >= currentWindow && reliableWindow < currentWindow + 8 - 1)
				break;
			droppedCommand = ENet_enet_list_next(self, currentCommand);
			if (startCommand != currentCommand) {
				ENet_enet_list_move(self, ENet_enet_list_end(self, peer->dispatchedCommands), startCommand, ENet_enet_list_previous(self, currentCommand));
				if (peer->needsDispatch == 0) {
					ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->host->dispatchQueue), &ENetPeer_dispatchList(peer)->base);
					peer->needsDispatch = 1;
				}
			}
		}
		startCommand = ENet_enet_list_next(self, currentCommand);
	}
	if (startCommand != currentCommand) {
		ENet_enet_list_move(self, ENet_enet_list_end(self, peer->dispatchedCommands), startCommand, ENet_enet_list_previous(self, currentCommand));
		if (peer->needsDispatch == 0) {
			ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->host->dispatchQueue), &ENetPeer_dispatchList(peer)->base);
			peer->needsDispatch = 1;
		}
		droppedCommand = currentCommand;
	}
	ENet_enet_peer_remove_incoming_commands(self, channel->incomingUnreliableCommands, ENet_enet_list_begin(self, channel->incomingUnreliableCommands), droppedCommand);
}

static void ENet_enet_peer_on_connect(ENet const *self, ENetPeer const *peer)
{
	if (peer->state != 5 && peer->state != 6) {
		if (peer->incomingBandwidth != 0)
			peer->host->bandwidthLimitedPeers++;
		peer->host->connectedPeers++;
	}
}

static void ENet_enet_peer_on_disconnect(ENet const *self, ENetPeer const *peer)
{
	if (peer->state == 5 || peer->state == 6) {
		if (peer->incomingBandwidth != 0)
			peer->host->bandwidthLimitedPeers--;
		peer->host->connectedPeers--;
	}
}

void ENet_enet_peer_ping(ENet const *self, ENetPeer *peer)
{
	ENetProtocol *command = ENetProtocol_New();
	if (peer->state != 5)
		return;
	command->header->command = 133;
	command->header->channelID = 255;
	ENet_enet_peer_queue_outgoing_command(self, peer, command, NULL, 0, 0);
}

void ENet_enet_peer_ping_interval(ENet const *self, ENetPeer *peer, int pingInterval)
{
	peer->pingInterval = pingInterval != 0 ? pingInterval : 500;
}

static ENetAcknowledgement const *ENet_enet_peer_queue_acknowledgement(ENet const *self, ENetPeer *peer, ENetProtocol const *command, ushort sentTime)
{
	ENetAcknowledgement *acknowledgement;
	if (command->header->channelID < peer->channelCount) {
		ENetChannel const *channel = peer->channels[command->header->channelID];
		ushort reliableWindow = self->p->vtbl->intToUshort(self->p, command->header->reliableSequenceNumber / 4096);
		ushort currentWindow = self->p->vtbl->intToUshort(self->p, channel->incomingReliableSequenceNumber / 4096);
		if (command->header->reliableSequenceNumber < channel->incomingReliableSequenceNumber)
			reliableWindow += 16;
		if (reliableWindow >= currentWindow + 8 - 1 && reliableWindow <= currentWindow + 8)
			return NULL;
	}
	acknowledgement = ENetAcknowledgement_New();
	if (acknowledgement == NULL)
		return NULL;
	peer->outgoingDataTotal += 8;
	acknowledgement->sentTime = sentTime;
	acknowledgement->command = command;
	ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->acknowledgements), &acknowledgement->base.base);
	return acknowledgement;
}

static ENetIncomingCommand *ENet_enet_peer_queue_incoming_command(ENet const *self, ENetPeer *peer, ENetProtocol const *command, ENetPacket *packet, int fragmentCount)
{
	ENetChannel *channel = peer->channels[command->header->channelID];
	int unreliableSequenceNumber = 0;
	int reliableSequenceNumber = 0;
	int reliableWindow;
	int currentWindow;
	ENetIncomingCommand *incomingCommand = NULL;
	ENetListNode const *currentCommand;
	if (peer->state == 6) {
		return ENet_freePacket(self, fragmentCount, packet);
	}
	if ((command->header->command & 15) != 9) {
		reliableSequenceNumber = command->header->reliableSequenceNumber;
		reliableWindow = reliableSequenceNumber / 4096;
		currentWindow = channel->incomingReliableSequenceNumber / 4096;
		if (reliableSequenceNumber < channel->incomingReliableSequenceNumber)
			reliableWindow += 16;
		if (reliableWindow < currentWindow || reliableWindow >= currentWindow + 8 - 1) {
			return ENet_freePacket(self, fragmentCount, packet);
		}
	}
	switch (command->header->command & 15) {
	case 8:
	case 6:
		if (reliableSequenceNumber == channel->incomingReliableSequenceNumber)
			return ENet_freePacket(self, fragmentCount, packet);
		for (currentCommand = ENet_enet_list_previous(self, ENet_enet_list_end(self, channel->incomingReliableCommands)); currentCommand != ENet_enet_list_end(self, channel->incomingReliableCommands); currentCommand = ENet_enet_list_previous(self, currentCommand)) {
			incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
			if (reliableSequenceNumber >= channel->incomingReliableSequenceNumber) {
				if (incomingCommand->reliableSequenceNumber < channel->incomingReliableSequenceNumber)
					continue;
			}
			else if (incomingCommand->reliableSequenceNumber >= channel->incomingReliableSequenceNumber)
				break;
			if (incomingCommand->reliableSequenceNumber <= reliableSequenceNumber) {
				if (incomingCommand->reliableSequenceNumber < reliableSequenceNumber)
					break;
				return ENet_freePacket(self, fragmentCount, packet);
			}
		}
		break;
	case 7:
	case 12:
		unreliableSequenceNumber = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->sendUnreliable->unreliableSequenceNumber);
		if (reliableSequenceNumber == channel->incomingReliableSequenceNumber && unreliableSequenceNumber <= channel->incomingUnreliableSequenceNumber)
			return ENet_freePacket(self, fragmentCount, packet);
		for (currentCommand = ENet_enet_list_previous(self, ENet_enet_list_end(self, channel->incomingUnreliableCommands)); currentCommand != ENet_enet_list_end(self, channel->incomingUnreliableCommands); currentCommand = ENet_enet_list_previous(self, currentCommand)) {
			incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
			if ((command->header->command & 15) == 9)
				continue;
			if (reliableSequenceNumber >= channel->incomingReliableSequenceNumber) {
				if (incomingCommand->reliableSequenceNumber < channel->incomingReliableSequenceNumber)
					continue;
			}
			else if (incomingCommand->reliableSequenceNumber >= channel->incomingReliableSequenceNumber)
				break;
			if (incomingCommand->reliableSequenceNumber < reliableSequenceNumber)
				break;
			if (incomingCommand->reliableSequenceNumber > reliableSequenceNumber)
				continue;
			if (incomingCommand->unreliableSequenceNumber <= unreliableSequenceNumber) {
				if (incomingCommand->unreliableSequenceNumber < unreliableSequenceNumber)
					break;
				return ENet_freePacket(self, fragmentCount, packet);
			}
		}
		break;
	case 9:
		currentCommand = ENet_enet_list_end(self, channel->incomingUnreliableCommands);
		break;
	default:
		return ENet_freePacket(self, fragmentCount, packet);
	}
	incomingCommand = ENetIncomingCommand_New();
	if (incomingCommand == NULL)
		return ENet_notifyError(self, packet);
	incomingCommand->reliableSequenceNumber = command->header->reliableSequenceNumber;
	incomingCommand->unreliableSequenceNumber = self->p->vtbl->intToUshort(self->p, unreliableSequenceNumber & 65535);
	incomingCommand->command = command;
	incomingCommand->fragmentCount = fragmentCount;
	incomingCommand->fragmentsRemaining = fragmentCount;
	incomingCommand->packet = packet;
	incomingCommand->fragments = NULL;
	if (fragmentCount > 0) {
		if (fragmentCount <= 1048576)
			incomingCommand->fragments = (int *) malloc((fragmentCount + 31) / 32 * sizeof(int ));
		if (incomingCommand->fragments == NULL) {
			free(incomingCommand);
			return ENet_notifyError(self, packet);
		}
		for (int i = 0; i < (fragmentCount + 31) / 32; i++) {
			incomingCommand->fragments[i] = 0;
		}
	}
	if (packet != NULL)
		packet->referenceCount++;
	ENet_enet_list_insert(self, ENet_enet_list_next(self, currentCommand), &incomingCommand->base.base);
	switch (command->header->command & 15) {
	case 8:
	case 6:
		ENet_enet_peer_dispatch_incoming_reliable_commands(self, peer, channel);
		break;
	default:
		ENet_enet_peer_dispatch_incoming_unreliable_commands(self, peer, channel);
		break;
	}
	return incomingCommand;
}

static ENetOutgoingCommand const *ENet_enet_peer_queue_outgoing_command(ENet const *self, ENetPeer *peer, ENetProtocol *command, ENetPacket *packet, int offset, ushort length)
{
	ENetOutgoingCommand *outgoingCommand = ENetOutgoingCommand_New();
	if (outgoingCommand == NULL)
		return NULL;
	outgoingCommand->command = command;
	outgoingCommand->fragmentOffset = offset;
	outgoingCommand->fragmentLength = length;
	outgoingCommand->packet = packet;
	if (packet != NULL)
		packet->referenceCount++;
	ENet_enet_peer_setup_outgoing_command(self, peer, outgoingCommand);
	return outgoingCommand;
}

ENetPacket const *ENet_enet_peer_receive(ENet const *self, ENetPeer const *peer, Byte *channelID)
{
	ENetIncomingCommand *incomingCommand;
	ENetPacket *packet;
	if (ENet_enet_list_empty(self, peer->dispatchedCommands))
		return NULL;
	incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &ENet_enet_list_remove(self, ENet_enet_list_begin(self, peer->dispatchedCommands))->base);
	if (channelID != NULL)
		channelID->value = incomingCommand->command->header->channelID;
	packet = incomingCommand->packet;
	packet->referenceCount--;
	if (incomingCommand->fragments != NULL) {
		free(incomingCommand->fragments);
	}
	free(incomingCommand);
	return packet;
}

void ENet_enet_peer_remove_incoming_commands(ENet const *self, ENetList const *queue, ENetListNode const *startCommand, ENetListNode const *endCommand)
{
	ENetListNode const *currentCommand;
	for (currentCommand = startCommand; currentCommand != endCommand;) {
		ENetIncomingCommand *incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
		currentCommand = ENet_enet_list_next(self, currentCommand);
		ENet_enet_list_remove(self, ENetIncomingCommand_incomingCommandList(incomingCommand));
		if (incomingCommand->packet != NULL) {
			incomingCommand->packet->referenceCount--;
			if (incomingCommand->packet->referenceCount == 0)
				ENet_enet_packet_destroy(self, incomingCommand->packet);
		}
		if (incomingCommand->fragments != NULL) {
			free(incomingCommand->fragments);
		}
		free(incomingCommand);
	}
}

void ENet_enet_peer_reset(ENet const *self, ENetPeer *peer)
{
	ENet_enet_peer_on_disconnect(self, peer);
	peer->outgoingPeerID = 4095;
	peer->connectID = 0;
	peer->state = 0;
	peer->incomingBandwidth = 0;
	peer->outgoingBandwidth = 0;
	peer->incomingBandwidthThrottleEpoch = 0;
	peer->outgoingBandwidthThrottleEpoch = 0;
	peer->incomingDataTotal = 0;
	peer->outgoingDataTotal = 0;
	peer->lastSendTime = 0;
	peer->lastReceiveTime = 0;
	peer->nextTimeout = 0;
	peer->earliestTimeout = 0;
	peer->packetLossEpoch = 0;
	peer->packetsSent = 0;
	peer->packetsLost = 0;
	peer->packetLoss = 0;
	peer->packetLossVariance = 0;
	peer->packetThrottle = 32;
	peer->packetThrottleLimit = 32;
	peer->packetThrottleCounter = 0;
	peer->packetThrottleEpoch = 0;
	peer->packetThrottleAcceleration = 2;
	peer->packetThrottleDeceleration = 2;
	peer->packetThrottleInterval = 5000;
	peer->pingInterval = 500;
	peer->timeoutLimit = 32;
	peer->timeoutMinimum = 5000;
	peer->timeoutMaximum = 30000;
	peer->lastRoundTripTime = 500;
	peer->lowestRoundTripTime = 500;
	peer->lastRoundTripTimeVariance = 0;
	peer->highestRoundTripTimeVariance = 0;
	peer->roundTripTime = 500;
	peer->roundTripTimeVariance = 0;
	peer->mtu = peer->host->mtu;
	peer->reliableDataInTransit = 0;
	peer->outgoingReliableSequenceNumber = 0;
	peer->windowSize = 32768;
	peer->incomingUnsequencedGroup = 0;
	peer->outgoingUnsequencedGroup = 0;
	peer->eventData = 0;
	for (int i = 0; i < 32; i++) {
		peer->unsequencedWindow[i] = 0;
	}
	ENet_enet_peer_reset_queues(self, peer);
}

void ENet_enet_peer_reset_incoming_commands(ENet const *self, ENetList const *queue)
{
	ENet_enet_peer_remove_incoming_commands(self, queue, ENet_enet_list_begin(self, queue), ENet_enet_list_end(self, queue));
}

void ENet_enet_peer_reset_outgoing_commands(ENet const *self, ENetList const *queue)
{
	ENetOutgoingCommand *outgoingCommand;
	while (!ENet_enet_list_empty(self, queue)) {
		outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &ENet_enet_list_remove(self, ENet_enet_list_begin(self, queue))->base);
		if (outgoingCommand->packet != NULL) {
			outgoingCommand->packet->referenceCount--;
			if (outgoingCommand->packet->referenceCount == 0)
				ENet_enet_packet_destroy(self, outgoingCommand->packet);
		}
		free(outgoingCommand);
	}
}

void ENet_enet_peer_reset_queues(ENet const *self, ENetPeer *peer)
{
	ENetChannel const *channel;
	if (peer->needsDispatch != 0) {
		ENet_enet_list_remove(self, ENetPeer_dispatchList(peer));
		peer->needsDispatch = 0;
	}
	while (!ENet_enet_list_empty(self, peer->acknowledgements)) {
		ENetListNode *n = ENet_enet_list_remove(self, ENet_enet_list_begin(self, peer->acknowledgements));
		free(n);
	}
	ENet_enet_peer_reset_outgoing_commands(self, peer->sentReliableCommands);
	ENet_enet_peer_reset_outgoing_commands(self, peer->sentUnreliableCommands);
	ENet_enet_peer_reset_outgoing_commands(self, peer->outgoingReliableCommands);
	ENet_enet_peer_reset_outgoing_commands(self, peer->outgoingUnreliableCommands);
	ENet_enet_peer_reset_incoming_commands(self, peer->dispatchedCommands);
	if (peer->channels != NULL && peer->channelCount > 0) {
		for (int i = 0; i < peer->channelCount; i++) {
			channel = peer->channels[i];
			ENet_enet_peer_reset_incoming_commands(self, channel->incomingReliableCommands);
			ENet_enet_peer_reset_incoming_commands(self, channel->incomingUnreliableCommands);
		}
		free(peer->channels);
	}
	peer->channels = NULL;
	peer->channelCount = 0;
}

int ENet_enet_peer_send(ENet const *self, ENetPeer *peer, unsigned char channelID, ENetPacket *packet)
{
	ENetChannel const *channel = peer->channels[channelID];
	ENetProtocol *command = ENetProtocol_New();
	int fragmentLength;
	if (peer->state != 5 || channelID >= peer->channelCount || packet->dataLength > 1073741824)
		return -1;
	fragmentLength = peer->mtu - 4 - 28;
	if (peer->host->checksum != NULL)
		fragmentLength -= 4;
	if (packet->dataLength > fragmentLength) {
		int fragmentCount = (packet->dataLength + fragmentLength - 1) / fragmentLength;
		int fragmentNumber;
		int fragmentOffset;
		unsigned char commandNumber;
		ushort startSequenceNumber;
		ENetList const *fragments = NULL;
		ENetOutgoingCommand *fragment;
		if (fragmentCount > 1048576)
			return -1;
		if ((packet->flags & 9) == 8 && channel->outgoingUnreliableSequenceNumber < 65535) {
			commandNumber = 12;
			startSequenceNumber = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, self->p->vtbl->intToUshort(self->p, channel->outgoingUnreliableSequenceNumber + 1));
		}
		else {
			commandNumber = 136;
			startSequenceNumber = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, self->p->vtbl->intToUshort(self->p, channel->outgoingReliableSequenceNumber + 1));
		}
		ENet_enet_list_clear(self, fragments);
		fragmentNumber = 0;
		fragmentOffset = 0;
		while (fragmentOffset < packet->dataLength) {
			if (packet->dataLength - fragmentOffset < fragmentLength)
				fragmentLength = packet->dataLength - fragmentOffset;
			fragment = ENetOutgoingCommand_New();
			if (fragment == NULL) {
				while (!ENet_enet_list_empty(self, fragments)) {
					fragment = self->p->vtbl->castToENetOutgoingCommand(self->p, ENet_enet_list_remove(self, ENet_enet_list_begin(self, fragments))->data);
					free(fragment);
				}
				return -1;
			}
			fragment->fragmentOffset = fragmentOffset;
			fragment->fragmentLength = self->p->vtbl->intToUshort(self->p, fragmentLength);
			fragment->packet = packet;
			fragment->command->header->command = commandNumber;
			fragment->command->header->channelID = channelID;
			fragment->command->sendFragment->startSequenceNumber = startSequenceNumber;
			fragment->command->sendFragment->dataLength = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, self->p->vtbl->intToUshort(self->p, fragmentLength));
			fragment->command->sendFragment->fragmentCount = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, fragmentCount);
			fragment->command->sendFragment->fragmentNumber = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, fragmentNumber);
			fragment->command->sendFragment->totalLength = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, packet->dataLength);
			fragment->command->sendFragment->fragmentOffset = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, fragmentOffset);
			ENet_enet_list_insert(self, ENet_enet_list_end(self, fragments), &fragment->base.base);
			fragmentNumber++;
			fragmentOffset += fragmentLength;
		}
		packet->referenceCount += fragmentNumber;
		while (!ENet_enet_list_empty(self, fragments)) {
			fragment = self->p->vtbl->castToENetOutgoingCommand(self->p, &ENet_enet_list_remove(self, ENet_enet_list_begin(self, fragments))->base);
			ENet_enet_peer_setup_outgoing_command(self, peer, fragment);
		}
		return 0;
	}
	command->header->channelID = channelID;
	if ((packet->flags & 3) == 2) {
		command->header->command = 73;
		command->sendUnsequenced->dataLength = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, self->p->vtbl->intToUshort(self->p, packet->dataLength));
	}
	else if ((packet->flags & 1) != 0 || channel->outgoingUnreliableSequenceNumber >= 65535) {
		command->header->command = 134;
		command->sendReliable = ENetProtocolSendReliable_New();
		command->sendReliable->dataLength = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, self->p->vtbl->intToUshort(self->p, packet->dataLength));
	}
	else {
		command->header->command = 7;
		command->sendUnreliable = ENetProtocolSendUnreliable_New();
		command->sendUnreliable->dataLength = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, self->p->vtbl->intToUshort(self->p, packet->dataLength));
	}
	if (ENet_enet_peer_queue_outgoing_command(self, peer, command, packet, 0, self->p->vtbl->intToUshort(self->p, packet->dataLength)) == NULL)
		return -1;
	return 0;
}

void ENet_enet_peer_setup_outgoing_command(ENet const *self, ENetPeer *peer, ENetOutgoingCommand *outgoingCommand)
{
	ENetChannel *channel = NULL;
	peer->outgoingDataTotal += ENet_enet_protocol_command_size(self, outgoingCommand->command->header->command) + outgoingCommand->fragmentLength;
	if (outgoingCommand->command->header->channelID == 255) {
		peer->outgoingReliableSequenceNumber++;
		outgoingCommand->reliableSequenceNumber = peer->outgoingReliableSequenceNumber;
		outgoingCommand->unreliableSequenceNumber = 0;
	}
	else {
		channel = peer->channels[outgoingCommand->command->header->channelID];
		if ((outgoingCommand->command->header->command & 128) != 0) {
			channel->outgoingReliableSequenceNumber++;
			channel->outgoingUnreliableSequenceNumber = 0;
			outgoingCommand->reliableSequenceNumber = channel->outgoingReliableSequenceNumber;
			outgoingCommand->unreliableSequenceNumber = 0;
		}
		else if ((outgoingCommand->command->header->command & 64) != 0) {
			peer->outgoingUnsequencedGroup++;
			outgoingCommand->reliableSequenceNumber = 0;
			outgoingCommand->unreliableSequenceNumber = 0;
		}
		else {
			if (outgoingCommand->fragmentOffset == 0)
				channel->outgoingUnreliableSequenceNumber++;
			outgoingCommand->reliableSequenceNumber = channel->outgoingReliableSequenceNumber;
			outgoingCommand->unreliableSequenceNumber = channel->outgoingUnreliableSequenceNumber;
		}
	}
	outgoingCommand->sendAttempts = 0;
	outgoingCommand->sentTime = 0;
	outgoingCommand->roundTripTimeout = 0;
	outgoingCommand->roundTripTimeoutLimit = 0;
	outgoingCommand->command->header->reliableSequenceNumber = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, outgoingCommand->reliableSequenceNumber);
	switch (outgoingCommand->command->header->command & 15) {
	case 7:
		outgoingCommand->command->sendUnreliable->unreliableSequenceNumber = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, outgoingCommand->unreliableSequenceNumber);
		break;
	case 9:
		outgoingCommand->command->sendUnsequenced->unsequencedGroup = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, peer->outgoingUnsequencedGroup);
		break;
	default:
		break;
	}
	if ((outgoingCommand->command->header->command & 128) != 0)
		ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->outgoingReliableCommands), &outgoingCommand->base.base);
	else
		ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->outgoingUnreliableCommands), &outgoingCommand->base.base);
}

static int ENet_enet_peer_throttle(ENet const *self, ENetPeer *peer, int rtt)
{
	if (peer->lastRoundTripTime <= peer->lastRoundTripTimeVariance) {
		peer->packetThrottle = peer->packetThrottleLimit;
	}
	else if (rtt < peer->lastRoundTripTime) {
		peer->packetThrottle += peer->packetThrottleAcceleration;
		if (peer->packetThrottle > peer->packetThrottleLimit)
			peer->packetThrottle = peer->packetThrottleLimit;
		return 1;
	}
	else if (rtt > peer->lastRoundTripTime + 2 * peer->lastRoundTripTimeVariance) {
		if (peer->packetThrottle > peer->packetThrottleDeceleration)
			peer->packetThrottle -= peer->packetThrottleDeceleration;
		else
			peer->packetThrottle = 0;
		return -1;
	}
	return 0;
}

void ENet_enet_peer_throttle_configure(ENet const *self, ENetPeer *peer, int interval, int acceleration, int deceleration)
{
	ENetProtocol *command = ENetProtocol_New();
	peer->packetThrottleInterval = interval;
	peer->packetThrottleAcceleration = acceleration;
	peer->packetThrottleDeceleration = deceleration;
	command->header->command = 139;
	command->header->channelID = 255;
	command->throttleConfigure->packetThrottleInterval = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, interval);
	command->throttleConfigure->packetThrottleAcceleration = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, acceleration);
	command->throttleConfigure->packetThrottleDeceleration = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, deceleration);
	ENet_enet_peer_queue_outgoing_command(self, peer, command, NULL, 0, 0);
}

void ENet_enet_peer_timeout(ENet const *self, ENetPeer *peer, int timeoutLimit, int timeoutMinimum, int timeoutMaximum)
{
	peer->timeoutLimit = timeoutLimit != 0 ? timeoutLimit : 32;
	peer->timeoutMinimum = timeoutMinimum != 0 ? timeoutMinimum : 5000;
	peer->timeoutMaximum = timeoutMaximum != 0 ? timeoutMaximum : 30000;
}

void ENet_enet_protocol_change_state(ENet const *self, ENetHost const *host, ENetPeer *peer, int state)
{
	if (state == 5 || state == 6)
		ENet_enet_peer_on_connect(self, peer);
	else
		ENet_enet_peer_on_disconnect(self, peer);
	peer->state = state;
}

int ENet_enet_protocol_check_timeouts(ENet const *self, ENetHost *host, ENetPeer *peer, ENetEvent *event_)
{
	ENetOutgoingCommand *outgoingCommand = NULL;
	ENetListNode const *currentCommand;
	ENetListNode *insertPosition;
	currentCommand = ENet_enet_list_begin(self, peer->sentReliableCommands);
	insertPosition = ENet_enet_list_begin(self, peer->outgoingReliableCommands);
	while (currentCommand != ENet_enet_list_end(self, peer->sentReliableCommands)) {
		outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &currentCommand->base);
		currentCommand = ENet_enet_list_next(self, currentCommand);
		if (ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, outgoingCommand->sentTime) < outgoingCommand->roundTripTimeout)
			continue;
		if (peer->earliestTimeout == 0 || ENet_ENET_TIME_LESS(self, outgoingCommand->sentTime, peer->earliestTimeout))
			peer->earliestTimeout = outgoingCommand->sentTime;
		if (peer->earliestTimeout != 0 && (ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, peer->earliestTimeout) >= peer->timeoutMaximum || (outgoingCommand->roundTripTimeout >= outgoingCommand->roundTripTimeoutLimit && ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, peer->earliestTimeout) >= peer->timeoutMinimum))) {
			ENet_enet_protocol_notify_disconnect(self, host, peer, event_);
			return 1;
		}
		if (outgoingCommand->packet != NULL)
			peer->reliableDataInTransit -= outgoingCommand->fragmentLength;
		peer->packetsLost++;
		outgoingCommand->roundTripTimeout *= 2;
		ENet_enet_list_insert(self, insertPosition, &ENet_enet_list_remove(self, ENetOutgoingCommand_outgoingCommandList(outgoingCommand))->base);
		if (currentCommand == ENet_enet_list_begin(self, peer->sentReliableCommands) && !ENet_enet_list_empty(self, peer->sentReliableCommands)) {
			outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &currentCommand->base);
			peer->nextTimeout = outgoingCommand->sentTime + outgoingCommand->roundTripTimeout;
		}
	}
	return 0;
}

static int ENet_enet_protocol_command_size(ENet const *self, unsigned char commandNumber)
{
	return self->commandSizes[commandNumber & 15];
}

int ENet_enet_protocol_dispatch_incoming_commands(ENet const *self, ENetHost *host, ENetEvent *event_)
{
	while (!ENet_enet_list_empty(self, host->dispatchQueue)) {
		ENetPeer *peer = self->p->vtbl->castToENetPeer(self->p, ENet_enet_list_remove(self, ENet_enet_list_begin(self, host->dispatchQueue)));
		peer->needsDispatch = 0;
		switch (peer->state) {
		case 3:
		case 4:
			ENet_enet_protocol_change_state(self, host, peer, 5);
			event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T;
			event_->peer = peer;
			event_->data = peer->eventData;
			return 1;
		case 9:
			host->recalculateBandwidthLimits = 1;
			event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T;
			event_->peer = peer;
			event_->data = peer->eventData;
			ENet_enet_peer_reset(self, peer);
			return 1;
		case 5:
			if (ENet_enet_list_empty(self, peer->dispatchedCommands))
				continue;
			Byte *b = Byte_New();
			b->value = event_->channelID;
			event_->packet = ENet_enet_peer_receive(self, peer, b);
			event_->channelID = b->value;
			if (event_->packet == NULL)
				continue;
			event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E;
			event_->peer = peer;
			if (!ENet_enet_list_empty(self, peer->dispatchedCommands)) {
				peer->needsDispatch = 1;
				ENet_enet_list_insert(self, ENet_enet_list_end(self, host->dispatchQueue), &ENetPeer_dispatchList(peer)->base);
			}
			return 1;
		default:
			break;
		}
	}
	return 0;
}

void ENet_enet_protocol_dispatch_state(ENet const *self, ENetHost const *host, ENetPeer *peer, int state)
{
	ENet_enet_protocol_change_state(self, host, peer, state);
	if (peer->needsDispatch == 0) {
		ENet_enet_list_insert(self, ENet_enet_list_end(self, host->dispatchQueue), &ENetPeer_dispatchList(peer)->base);
		peer->needsDispatch = 1;
	}
}

int ENet_enet_protocol_handle_acknowledge(ENet *self, ENetHost *host, ENetEvent *event_, ENetPeer *peer, ENetProtocol const *command)
{
	int roundTripTime;
	int receivedSentTime;
	int receivedReliableSequenceNumber;
	int commandNumber;
	if (peer->state == 0 || peer->state == 9)
		return 0;
	receivedSentTime = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->acknowledge->receivedSentTime);
	receivedSentTime |= host->serviceTime & -65536;
	if ((receivedSentTime & 32768) > (host->serviceTime & 32768))
		receivedSentTime -= 65536;
	if (ENet_ENET_TIME_LESS(self, host->serviceTime, receivedSentTime))
		return 0;
	peer->lastReceiveTime = host->serviceTime;
	peer->earliestTimeout = 0;
	roundTripTime = ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, receivedSentTime);
	ENet_enet_peer_throttle(self, peer, roundTripTime);
	peer->roundTripTimeVariance -= peer->roundTripTimeVariance / 4;
	if (roundTripTime >= peer->roundTripTime) {
		peer->roundTripTime += (roundTripTime - peer->roundTripTime) / 8;
		peer->roundTripTimeVariance += (roundTripTime - peer->roundTripTime) / 4;
	}
	else {
		peer->roundTripTime -= (peer->roundTripTime - roundTripTime) / 8;
		peer->roundTripTimeVariance += (peer->roundTripTime - roundTripTime) / 4;
	}
	if (peer->roundTripTime < peer->lowestRoundTripTime)
		peer->lowestRoundTripTime = peer->roundTripTime;
	if (peer->roundTripTimeVariance > peer->highestRoundTripTimeVariance)
		peer->highestRoundTripTimeVariance = peer->roundTripTimeVariance;
	if (peer->packetThrottleEpoch == 0 || ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, peer->packetThrottleEpoch) >= peer->packetThrottleInterval) {
		peer->lastRoundTripTime = peer->lowestRoundTripTime;
		peer->lastRoundTripTimeVariance = peer->highestRoundTripTimeVariance;
		peer->lowestRoundTripTime = peer->roundTripTime;
		peer->highestRoundTripTimeVariance = peer->roundTripTimeVariance;
		peer->packetThrottleEpoch = host->serviceTime;
	}
	receivedReliableSequenceNumber = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->acknowledge->receivedReliableSequenceNumber);
	commandNumber = ENet_enet_protocol_remove_sent_reliable_command(self, peer, self->p->vtbl->intToUshort(self->p, receivedReliableSequenceNumber), command->header->channelID);
	switch (peer->state) {
	case 2:
		if (commandNumber != 3)
			return -1;
		ENet_enet_protocol_notify_connect(self, host, peer, event_);
		break;
	case 7:
		if (commandNumber != 4)
			return -1;
		ENet_enet_protocol_notify_disconnect(self, host, peer, event_);
		break;
	case 6:
		if (ENet_enet_list_empty(self, peer->outgoingReliableCommands) && ENet_enet_list_empty(self, peer->outgoingUnreliableCommands) && ENet_enet_list_empty(self, peer->sentReliableCommands))
			ENet_enet_peer_disconnect(self, peer, peer->eventData);
		break;
	default:
		break;
	}
	return 0;
}

int ENet_enet_protocol_handle_bandwidth_limit(ENet const *self, ENetHost *host, ENetPeer *peer, ENetProtocol const *command)
{
	if (peer->state != 5 && peer->state != 6)
		return -1;
	if (peer->incomingBandwidth != 0)
		host->bandwidthLimitedPeers--;
	peer->incomingBandwidth = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->bandwidthLimit->incomingBandwidth);
	peer->outgoingBandwidth = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->bandwidthLimit->outgoingBandwidth);
	if (peer->incomingBandwidth != 0)
		host->bandwidthLimitedPeers++;
	if (peer->incomingBandwidth == 0 && host->outgoingBandwidth == 0)
		peer->windowSize = 32768;
	else
		peer->windowSize = ENet_ENET_MIN(self, peer->incomingBandwidth, host->outgoingBandwidth) / 65536 * 4096;
	if (peer->windowSize < 4096)
		peer->windowSize = 4096;
	else if (peer->windowSize > 32768)
		peer->windowSize = 32768;
	return 0;
}

ENetPeer *ENet_enet_protocol_handle_connect(ENet const *self, ENetHost const *host, ENetProtocolHeader const *header, ENetProtocol const *command)
{
	unsigned char incomingSessionID;
	unsigned char outgoingSessionID;
	int mtu;
	int windowSize;
	ENetChannel *channel;
	int channelCount;
	ENetPeer *currentPeer = ENetPeer_New();
	ENetProtocol *verifyCommand = ENetProtocol_New();
	channelCount = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->channelCount);
	if (channelCount < 1 || channelCount > 255)
		return NULL;
	int i;
	for (i = 0; i < host->peerCount; i++) {
		currentPeer = host->peers[i];
		if (currentPeer->state != 0 && currentPeer->address->host == host->receivedAddress->host && currentPeer->address->port == host->receivedAddress->port && currentPeer->connectID == command->connect->connectID)
			return NULL;
	}
	for (i = 0; i < host->peerCount; i++) {
		currentPeer = host->peers[i];
		if (currentPeer->state == 0)
			break;
	}
	if (i >= host->peerCount)
		return NULL;
	if (channelCount > host->channelLimit)
		channelCount = host->channelLimit;
	currentPeer->channels = (ENetChannel const **) malloc(channelCount * sizeof(ENetChannel const *));
	for (int k = 0; k < channelCount; k++) {
		currentPeer->channels[k] = ENetChannel_New();
	}
	if (currentPeer->channels == NULL)
		return NULL;
	currentPeer->channelCount = channelCount;
	currentPeer->state = 2;
	currentPeer->connectID = command->connect->connectID;
	currentPeer->address = host->receivedAddress;
	currentPeer->outgoingPeerID = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->connect->outgoingPeerID);
	currentPeer->incomingBandwidth = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->incomingBandwidth);
	currentPeer->outgoingBandwidth = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->outgoingBandwidth);
	currentPeer->packetThrottleInterval = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->packetThrottleInterval);
	currentPeer->packetThrottleAcceleration = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->packetThrottleAcceleration);
	currentPeer->packetThrottleDeceleration = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->packetThrottleDeceleration);
	currentPeer->eventData = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->data);
	incomingSessionID = command->connect->incomingSessionID == 255 ? currentPeer->outgoingSessionID : command->connect->incomingSessionID;
	incomingSessionID = ENet_ToByte((incomingSessionID + 1) & 3);
	if (incomingSessionID == currentPeer->outgoingSessionID)
		incomingSessionID = ENet_ToByte((incomingSessionID + 1) & 3);
	currentPeer->outgoingSessionID = incomingSessionID;
	outgoingSessionID = command->connect->outgoingSessionID == 255 ? currentPeer->incomingSessionID : command->connect->outgoingSessionID;
	outgoingSessionID = ENet_ToByte((outgoingSessionID + 1) & 3);
	if (outgoingSessionID == currentPeer->incomingSessionID)
		outgoingSessionID = ENet_ToByte((outgoingSessionID + 1) & 3);
	currentPeer->incomingSessionID = outgoingSessionID;
	for (i = 0; i < currentPeer->channelCount; i++) {
		channel = currentPeer->channels[i];
		channel->outgoingReliableSequenceNumber = 0;
		channel->outgoingUnreliableSequenceNumber = 0;
		channel->incomingReliableSequenceNumber = 0;
		channel->incomingUnreliableSequenceNumber = 0;
		ENet_enet_list_clear(self, channel->incomingReliableCommands);
		ENet_enet_list_clear(self, channel->incomingUnreliableCommands);
		channel->usedReliableWindows = 0;
		for (int k = 0; k < 16; k++) {
			channel->reliableWindows[k] = 0;
		}
	}
	mtu = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->mtu);
	if (mtu < 576)
		mtu = 576;
	else if (mtu > 4096)
		mtu = 4096;
	currentPeer->mtu = mtu;
	if (host->outgoingBandwidth == 0 && currentPeer->incomingBandwidth == 0)
		currentPeer->windowSize = 32768;
	else if (host->outgoingBandwidth == 0 || currentPeer->incomingBandwidth == 0)
		currentPeer->windowSize = ENet_ENET_MAX(self, host->outgoingBandwidth, currentPeer->incomingBandwidth) / 65536 * 4096;
	else
		currentPeer->windowSize = ENet_ENET_MIN(self, host->outgoingBandwidth, currentPeer->incomingBandwidth) / 65536 * 4096;
	if (currentPeer->windowSize < 4096)
		currentPeer->windowSize = 4096;
	else if (currentPeer->windowSize > 32768)
		currentPeer->windowSize = 32768;
	if (host->incomingBandwidth == 0)
		windowSize = 32768;
	else
		windowSize = host->incomingBandwidth / 65536 * 4096;
	if (windowSize > self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->windowSize))
		windowSize = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->connect->windowSize);
	if (windowSize < 4096)
		windowSize = 4096;
	else if (windowSize > 32768)
		windowSize = 32768;
	verifyCommand->header = ENetProtocolCommandHeader_New();
	verifyCommand->header->command = 131;
	verifyCommand->header->channelID = 255;
	verifyCommand->verifyConnect = ENetProtocolVerifyConnect_New();
	verifyCommand->verifyConnect->outgoingPeerID = self->p->vtbl->eNET_HOST_TO_NET_16(self->p, currentPeer->incomingPeerID);
	verifyCommand->verifyConnect->incomingSessionID = incomingSessionID;
	verifyCommand->verifyConnect->outgoingSessionID = outgoingSessionID;
	verifyCommand->verifyConnect->mtu = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->mtu);
	verifyCommand->verifyConnect->windowSize = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, windowSize);
	verifyCommand->verifyConnect->channelCount = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, channelCount);
	verifyCommand->verifyConnect->incomingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, host->incomingBandwidth);
	verifyCommand->verifyConnect->outgoingBandwidth = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, host->outgoingBandwidth);
	verifyCommand->verifyConnect->packetThrottleInterval = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->packetThrottleInterval);
	verifyCommand->verifyConnect->packetThrottleAcceleration = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->packetThrottleAcceleration);
	verifyCommand->verifyConnect->packetThrottleDeceleration = self->p->vtbl->eNET_HOST_TO_NET_32(self->p, currentPeer->packetThrottleDeceleration);
	verifyCommand->verifyConnect->connectID = currentPeer->connectID;
	ENet_enet_peer_queue_outgoing_command(self, currentPeer, verifyCommand, NULL, 0, 0);
	return currentPeer;
}

int ENet_enet_protocol_handle_disconnect(ENet const *self, ENetHost *host, ENetPeer *peer, ENetProtocol const *command)
{
	if (peer->state == 0 || peer->state == 9 || peer->state == 8)
		return 0;
	ENet_enet_peer_reset_queues(self, peer);
	if (peer->state == 4 || peer->state == 7)
		ENet_enet_protocol_dispatch_state(self, host, peer, 9);
	else if (peer->state != 5 && peer->state != 6) {
		if (peer->state == 3)
			host->recalculateBandwidthLimits = 1;
		ENet_enet_peer_reset(self, peer);
	}
	else if ((command->header->command & 128) != 0)
		ENet_enet_protocol_change_state(self, host, peer, 8);
	else
		ENet_enet_protocol_dispatch_state(self, host, peer, 9);
	if (peer->state != 0)
		peer->eventData = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->disconnect->data);
	return 0;
}

int ENet_enet_protocol_handle_incoming_commands(ENet *self, ENetHost *host, ENetEvent *event_)
{
	ENetProtocolHeader const *header;
	ENetProtocol *command = NULL;
	ENetPeer *peer;
	unsigned char const *currentData = NULL;
	int headerSize = 0;
	ushort peerID;
	ushort flags;
	int sessionID;
	int *currentDataI = (int *) malloc(1 * sizeof(int ));
	currentDataI[0] = 0;
	header = ENet_Deserialize(self, host->receivedData);
	peerID = ENet_ENET_NET_TO_HOST_16(self, header->peerID);
	sessionID = (peerID & 12288) >> 12;
	flags = self->p->vtbl->intToUshort(self->p, peerID & 49152);
	peerID &= self->p->vtbl->intToUshort(self->p, ~61440);
	headerSize = (flags & 32768) != 0 ? 4 : 2;
	if (host->checksum != NULL)
		headerSize += 4;
	if (peerID == 4095)
		peer = NULL;
	else if (peerID >= host->peerCount)
		return 0;
	else {
		peer = host->peers[peerID];
		if (peer->state == 0 || peer->state == 9 || ((host->receivedAddress->host != peer->address->host || host->receivedAddress->port != peer->address->port) && peer->address->host != -1) || (peer->outgoingPeerID < 4095 && sessionID != peer->incomingSessionID))
			return 0;
	}
	if ((flags & 16384) != 0) {
		int originalSize = 0;
		if (host->compressor == NULL)
			return 0;
		for (int i = 0; i < headerSize; i++) {
		}
		host->receivedData = host->packetData[1];
		host->receivedDataLength = headerSize + originalSize;
	}
	if (host->checksum != NULL) {
		int checksum = 0;
		int desiredChecksum = checksum;
		ENetBuffer *buffer = ENetBuffer_New();
		checksum = peer != NULL ? peer->connectID : 0;
		buffer->data = host->receivedData;
		buffer->dataLength = host->receivedDataLength;
		if (host->checksum->vtbl->run(host->checksum, buffer, 1) != desiredChecksum)
			return 0;
	}
	if (peer != NULL) {
		peer->address->host = host->receivedAddress->host;
		peer->address->port = host->receivedAddress->port;
		peer->incomingDataTotal += host->receivedDataLength;
	}
	currentDataI[0] += headerSize;
	int test = 0;
	while (currentDataI[0] < host->receivedDataLength) {
		unsigned char commandNumber;
		int commandSize;
		if (test > 0) {
		}
		test++;
		if (currentDataI[0] + 4 > host->receivedDataLength)
			break;
		command = ENet_DeserializeProtocolCommandHeader(self, host->receivedData, currentDataI[0]);
		commandNumber = ENet_ToByte(command->header->command & 15);
		if (commandNumber == 0) {
		}
		if (commandNumber >= 13)
			break;
		commandSize = self->commandSizes[commandNumber];
		if (commandSize == 0 || currentDataI[0] + commandSize > host->receivedDataLength)
			break;
		ENet_DeserializeProtocolCommandCommand(self, host->receivedData, currentDataI[0], commandNumber, command);
		currentDataI[0] += commandSize;
		if (peer == NULL && commandNumber != 2)
			break;
		command->header->reliableSequenceNumber = ENet_ENET_NET_TO_HOST_16(self, command->header->reliableSequenceNumber);
		if (self->test1 == 1) {
		}
		if (command->header->reliableSequenceNumber == 1) {
			self->test1++;
		}
		switch (commandNumber) {
		case 1:
			if (ENet_enet_protocol_handle_acknowledge(self, host, event_, peer, command) != 0)
				return ENet_commandError(self, event_);
			break;
		case 2:
			if (peer != NULL)
				return ENet_commandError(self, event_);
			peer = ENet_enet_protocol_handle_connect(self, host, header, command);
			if (peer == NULL)
				return ENet_commandError(self, event_);
			break;
		case 3:
			if (ENet_enet_protocol_handle_verify_connect(self, host, event_, peer, command) != 0)
				return ENet_commandError(self, event_);
			break;
		case 4:
			if (ENet_enet_protocol_handle_disconnect(self, host, peer, command) != 0)
				return ENet_commandError(self, event_);
			break;
		case 5:
			if (ENet_enet_protocol_handle_ping(self, host, peer, command) != 0)
				return ENet_commandError(self, event_);
			break;
		case 6:
			if (ENet_enet_protocol_handle_send_reliable(self, host, peer, command, host->receivedData, currentDataI) != 0)
				return ENet_commandError(self, event_);
			break;
		case 7:
			if (ENet_enet_protocol_handle_send_unreliable(self, host, peer, command, host->receivedData, currentDataI) != 0)
				return ENet_commandError(self, event_);
			break;
		case 9:
			if (ENet_enet_protocol_handle_send_unsequenced(self, host, peer, command, currentData) != 0)
				return ENet_commandError(self, event_);
			break;
		case 8:
			if (ENet_enet_protocol_handle_send_fragment(self, host, peer, command, host->receivedData, currentDataI) != 0)
				return ENet_commandError(self, event_);
			break;
		case 10:
			if (ENet_enet_protocol_handle_bandwidth_limit(self, host, peer, command) != 0)
				return ENet_commandError(self, event_);
			break;
		case 11:
			if (ENet_enet_protocol_handle_throttle_configure(self, host, peer, command) != 0)
				return ENet_commandError(self, event_);
			break;
		case 12:
			if (ENet_enet_protocol_handle_send_unreliable_fragment(self, host, peer, command, currentData) != 0)
				return ENet_commandError(self, event_);
			break;
		default:
			return ENet_commandError(self, event_);
		}
		if (peer != NULL && (command->header->command & 128) != 0) {
			ushort sentTime;
			if ((flags & 32768) == 0)
				break;
			sentTime = ENet_ENET_NET_TO_HOST_16(self, header->sentTime);
			switch (peer->state) {
			case 7:
			case 2:
			case 0:
			case 9:
				break;
			case 8:
				if ((command->header->command & 15) == 4)
					ENet_enet_peer_queue_acknowledgement(self, peer, command, sentTime);
				break;
			default:
				ENet_enet_peer_queue_acknowledgement(self, peer, command, sentTime);
				break;
			}
		}
	}
	if (event_ != NULL && event_->type != ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E) {
		return 1;
	}
	return 0;
}

int ENet_enet_protocol_handle_ping(ENet const *self, ENetHost const *host, ENetPeer const *peer, ENetProtocol const *command)
{
	if (peer->state != 5 && peer->state != 6)
		return -1;
	return 0;
}

int ENet_enet_protocol_handle_send_fragment(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol const *command, unsigned char const *currentData, int *currentDataI)
{
	int fragmentNumber;
	int fragmentCount;
	int fragmentOffset;
	int fragmentLength;
	int startSequenceNumber;
	int totalLength;
	ENetChannel *channel;
	ushort startWindow;
	ushort currentWindow;
	ENetListNode const *currentCommand;
	ENetIncomingCommand *startCommand = NULL;
	if (command->header->channelID >= peer->channelCount || (peer->state != 5 && peer->state != 6))
		return -1;
	fragmentLength = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->sendFragment->dataLength);
	currentDataI[0] += fragmentLength;
	if (fragmentLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host->receivedDataLength)
		return -1;
	channel = peer->channels[command->header->channelID];
	startSequenceNumber = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->sendFragment->startSequenceNumber);
	startWindow = self->p->vtbl->intToUshort(self->p, startSequenceNumber / 4096);
	currentWindow = self->p->vtbl->intToUshort(self->p, channel->incomingReliableSequenceNumber / 4096);
	if (startSequenceNumber < channel->incomingReliableSequenceNumber)
		startWindow += 16;
	if (startWindow < currentWindow || startWindow >= currentWindow + 8 - 1)
		return 0;
	fragmentNumber = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->sendFragment->fragmentNumber);
	fragmentCount = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->sendFragment->fragmentCount);
	fragmentOffset = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->sendFragment->fragmentOffset);
	totalLength = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->sendFragment->totalLength);
	if (fragmentCount > 1048576 || fragmentNumber >= fragmentCount || totalLength > 1073741824 || fragmentOffset >= totalLength || fragmentLength > totalLength - fragmentOffset)
		return -1;
	for (currentCommand = ENet_enet_list_previous(self, ENet_enet_list_end(self, channel->incomingReliableCommands)); currentCommand != ENet_enet_list_end(self, channel->incomingReliableCommands); currentCommand = ENet_enet_list_previous(self, currentCommand)) {
		ENetIncomingCommand *incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
		if (startSequenceNumber >= channel->incomingReliableSequenceNumber) {
			if (incomingCommand->reliableSequenceNumber < channel->incomingReliableSequenceNumber)
				continue;
		}
		else if (incomingCommand->reliableSequenceNumber >= channel->incomingReliableSequenceNumber)
			break;
		if (incomingCommand->reliableSequenceNumber <= startSequenceNumber) {
			if (incomingCommand->reliableSequenceNumber < startSequenceNumber)
				break;
			if ((incomingCommand->command->header->command & 15) != 8 || totalLength != incomingCommand->packet->dataLength || fragmentCount != incomingCommand->fragmentCount)
				return -1;
			startCommand = incomingCommand;
			break;
		}
	}
	if (startCommand == NULL) {
		ENetProtocol const *hostCommand = command;
		ENetPacket *packet = ENet_enet_packet_create(self, NULL, totalLength, 1);
		if (packet == NULL)
			return -1;
		hostCommand->header->reliableSequenceNumber = self->p->vtbl->intToUshort(self->p, startSequenceNumber);
		startCommand = ENet_enet_peer_queue_incoming_command(self, peer, hostCommand, packet, fragmentCount);
		if (startCommand == NULL)
			return -1;
	}
	if ((startCommand->fragments[fragmentNumber / 32] & (1 << fragmentNumber % 32)) == 0) {
		startCommand->fragmentsRemaining--;
		startCommand->fragments[fragmentNumber / 32] |= 1 << fragmentNumber % 32;
		if (fragmentOffset + fragmentLength > startCommand->packet->dataLength)
			fragmentLength = startCommand->packet->dataLength - fragmentOffset;
		unsigned char *data = (unsigned char *) malloc(128 * sizeof(unsigned char ));
		ENet_SerializeCommand(self, data, command);
		for (int i = 0; i < fragmentLength; i++) {
			startCommand->packet->data[i + fragmentOffset] = data[i + 28];
		}
		if (startCommand->fragmentsRemaining <= 0)
			ENet_enet_peer_dispatch_incoming_reliable_commands(self, peer, channel);
	}
	return 0;
}

static int ENet_enet_protocol_handle_send_reliable(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol *command, unsigned char const *currentData, int *currentDataI)
{
	ENetPacket *packet;
	int dataLength;
	if (command->header->channelID >= peer->channelCount || (peer->state != 5 && peer->state != 6))
		return -1;
	dataLength = ENet_ENET_NET_TO_HOST_16(self, command->sendReliable->dataLength);
	if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host->receivedDataLength)
		return -1;
	command->data = (unsigned char *) malloc(dataLength * sizeof(unsigned char ));
	for (int i = 0; i < dataLength; i++) {
		command->data[i] = currentData[currentDataI[0] + i];
	}
	currentDataI[0] += dataLength;
	packet = ENet_enet_packet_create(self, command->data, dataLength, 1);
	if (packet == NULL || ENet_enet_peer_queue_incoming_command(self, peer, command, packet, 0) == NULL)
		return -1;
	return 0;
}

int ENet_enet_protocol_handle_send_unreliable(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol *command, unsigned char const *currentData, int *currentDataI)
{
	ENetPacket *packet;
	int dataLength;
	if (command->header->channelID >= peer->channelCount || (peer->state != 5 && peer->state != 6))
		return -1;
	dataLength = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->sendUnreliable->dataLength);
	currentDataI[0] += dataLength;
	if (dataLength > 1073741824 || currentDataI[0] < 0 || currentDataI[0] > host->receivedDataLength)
		return -1;
	command->data = (unsigned char *) malloc(dataLength * sizeof(unsigned char ));
	for (int i = 0; i < dataLength; i++) {
		command->data[i] = currentData[currentDataI[0] - dataLength + i];
	}
	packet = ENet_enet_packet_create(self, command->data, dataLength, 0);
	if (packet == NULL || ENet_enet_peer_queue_incoming_command(self, peer, command, packet, 0) == NULL)
		return -1;
	return 0;
}

int ENet_enet_protocol_handle_send_unreliable_fragment(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol const *command, unsigned char const *currentData)
{
	int fragmentNumber;
	int fragmentCount;
	int fragmentOffset;
	int fragmentLength;
	int reliableSequenceNumber;
	int startSequenceNumber;
	int totalLength;
	ushort reliableWindow;
	ushort currentWindow;
	ENetChannel *channel;
	ENetListNode const *currentCommand;
	ENetIncomingCommand *startCommand = NULL;
	if (command->header->channelID >= peer->channelCount || (peer->state != 5 && peer->state != 6))
		return -1;
	fragmentLength = ENet_ENET_NET_TO_HOST_16(self, command->sendFragment->dataLength);
	int currentDataI = 0;
	currentDataI += fragmentLength;
	if (fragmentLength > 1073741824 || currentDataI < 0 || currentDataI > host->receivedDataLength)
		return -1;
	channel = peer->channels[command->header->channelID];
	reliableSequenceNumber = command->header->reliableSequenceNumber;
	startSequenceNumber = ENet_ENET_NET_TO_HOST_16(self, command->sendFragment->startSequenceNumber);
	reliableWindow = self->p->vtbl->intToUshort(self->p, reliableSequenceNumber / 4096);
	currentWindow = self->p->vtbl->intToUshort(self->p, channel->incomingReliableSequenceNumber / 4096);
	if (reliableSequenceNumber < channel->incomingReliableSequenceNumber)
		reliableWindow += 16;
	if (reliableWindow < currentWindow || reliableWindow >= currentWindow + 8 - 1)
		return 0;
	if (reliableSequenceNumber == channel->incomingReliableSequenceNumber && startSequenceNumber <= channel->incomingUnreliableSequenceNumber)
		return 0;
	fragmentNumber = ENet_ENET_NET_TO_HOST_32(self, command->sendFragment->fragmentNumber);
	fragmentCount = ENet_ENET_NET_TO_HOST_32(self, command->sendFragment->fragmentCount);
	fragmentOffset = ENet_ENET_NET_TO_HOST_32(self, command->sendFragment->fragmentOffset);
	totalLength = ENet_ENET_NET_TO_HOST_32(self, command->sendFragment->totalLength);
	if (fragmentCount > 1048576 || fragmentNumber >= fragmentCount || totalLength > 1073741824 || fragmentOffset >= totalLength || fragmentLength > totalLength - fragmentOffset)
		return -1;
	for (currentCommand = ENet_enet_list_previous(self, ENet_enet_list_end(self, channel->incomingUnreliableCommands)); currentCommand != ENet_enet_list_end(self, channel->incomingUnreliableCommands); currentCommand = ENet_enet_list_previous(self, currentCommand)) {
		ENetIncomingCommand *incomingCommand = self->p->vtbl->castToENetIncomingCommand(self->p, &currentCommand->base);
		if (reliableSequenceNumber >= channel->incomingReliableSequenceNumber) {
			if (incomingCommand->reliableSequenceNumber < channel->incomingReliableSequenceNumber)
				continue;
		}
		else if (incomingCommand->reliableSequenceNumber >= channel->incomingReliableSequenceNumber)
			break;
		if (incomingCommand->reliableSequenceNumber < reliableSequenceNumber)
			break;
		if (incomingCommand->reliableSequenceNumber > reliableSequenceNumber)
			continue;
		if (incomingCommand->unreliableSequenceNumber <= startSequenceNumber) {
			if (incomingCommand->unreliableSequenceNumber < startSequenceNumber)
				break;
			if ((incomingCommand->command->header->command & 15) != 12 || totalLength != incomingCommand->packet->dataLength || fragmentCount != incomingCommand->fragmentCount)
				return -1;
			startCommand = incomingCommand;
			break;
		}
	}
	if (startCommand == NULL) {
		ENetPacket *packet = ENet_enet_packet_create(self, NULL, totalLength, 8);
		if (packet == NULL)
			return -1;
		startCommand = ENet_enet_peer_queue_incoming_command(self, peer, command, packet, fragmentCount);
		if (startCommand == NULL)
			return -1;
	}
	if ((startCommand->fragments[fragmentNumber / 32] & (1 << fragmentNumber % 32)) == 0) {
		startCommand->fragmentsRemaining--;
		startCommand->fragments[fragmentNumber / 32] |= 1 << fragmentNumber % 32;
		if (fragmentOffset + fragmentLength > startCommand->packet->dataLength)
			fragmentLength = startCommand->packet->dataLength - fragmentOffset;
		for (int i = 0; i < fragmentLength; i++) {
			startCommand->packet->data[fragmentOffset + i] = command->data[i];
		}
		if (startCommand->fragmentsRemaining <= 0)
			ENet_enet_peer_dispatch_incoming_unreliable_commands(self, peer, channel);
	}
	return 0;
}

int ENet_enet_protocol_handle_send_unsequenced(ENet const *self, ENetHost const *host, ENetPeer const *peer, ENetProtocol const *command, unsigned char const *currentData)
{
	return 0;
}

int ENet_enet_protocol_handle_throttle_configure(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol const *command)
{
	if (peer->state != 5 && peer->state != 6)
		return -1;
	peer->packetThrottleInterval = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->throttleConfigure->packetThrottleInterval);
	peer->packetThrottleAcceleration = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->throttleConfigure->packetThrottleAcceleration);
	peer->packetThrottleDeceleration = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->throttleConfigure->packetThrottleDeceleration);
	return 0;
}

int ENet_enet_protocol_handle_verify_connect(ENet const *self, ENetHost *host, ENetEvent *event_, ENetPeer *peer, ENetProtocol const *command)
{
	int mtu;
	int windowSize;
	int channelCount;
	if (peer->state != 1)
		return 0;
	channelCount = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->channelCount);
	if (channelCount < 1 || channelCount > 255 || self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->packetThrottleInterval) != peer->packetThrottleInterval || self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->packetThrottleAcceleration) != peer->packetThrottleAcceleration || self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->packetThrottleDeceleration) != peer->packetThrottleDeceleration || command->verifyConnect->connectID != peer->connectID) {
		peer->eventData = 0;
		ENet_enet_protocol_dispatch_state(self, host, peer, 9);
		return -1;
	}
	ENet_enet_protocol_remove_sent_reliable_command(self, peer, 1, 255);
	if (channelCount < peer->channelCount)
		peer->channelCount = channelCount;
	peer->outgoingPeerID = self->p->vtbl->eNET_NET_TO_HOST_16(self->p, command->verifyConnect->outgoingPeerID);
	peer->incomingSessionID = command->verifyConnect->incomingSessionID;
	peer->outgoingSessionID = command->verifyConnect->outgoingSessionID;
	mtu = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->mtu);
	if (mtu < 576)
		mtu = 576;
	else if (mtu > 4096)
		mtu = 4096;
	if (mtu < peer->mtu)
		peer->mtu = mtu;
	windowSize = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->windowSize);
	if (windowSize < 4096)
		windowSize = 4096;
	if (windowSize > 32768)
		windowSize = 32768;
	if (windowSize < peer->windowSize)
		peer->windowSize = windowSize;
	peer->incomingBandwidth = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->incomingBandwidth);
	peer->outgoingBandwidth = self->p->vtbl->eNET_NET_TO_HOST_32(self->p, command->verifyConnect->outgoingBandwidth);
	ENet_enet_protocol_notify_connect(self, host, peer, event_);
	return 0;
}

void ENet_enet_protocol_notify_connect(ENet const *self, ENetHost *host, ENetPeer *peer, ENetEvent *event_)
{
	host->recalculateBandwidthLimits = 1;
	if (event_ != NULL) {
		ENet_enet_protocol_change_state(self, host, peer, 5);
		event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T;
		event_->peer = peer;
		event_->data = peer->eventData;
	}
	else
		ENet_enet_protocol_dispatch_state(self, host, peer, peer->state == 1 ? 4 : 3);
}

void ENet_enet_protocol_notify_disconnect(ENet const *self, ENetHost *host, ENetPeer *peer, ENetEvent *event_)
{
	if (peer->state >= 3)
		host->recalculateBandwidthLimits = 1;
	if (peer->state != 1 && peer->state < 4)
		ENet_enet_peer_reset(self, peer);
	else if (event_ != NULL) {
		event_->type = ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T;
		event_->peer = peer;
		event_->data = 0;
		ENet_enet_peer_reset(self, peer);
	}
	else {
		peer->eventData = 0;
		ENet_enet_protocol_dispatch_state(self, host, peer, 9);
	}
}

int ENet_enet_protocol_receive_incoming_commands(ENet *self, ENetHost *host, ENetEvent *event_)
{
	for (;;) {
		int receivedLength;
		ENetBuffer *buffer = ENetBuffer_New();
		buffer->data = host->packetData[0];
		buffer->dataLength = 4096;
		ENetBuffer const **buffers = (ENetBuffer const **) malloc(1 * sizeof(ENetBuffer const *));
		buffers[0] = buffer;
		receivedLength = self->p->vtbl->enet_socket_receive(self->p, host->socket, host->receivedAddress, buffers, 1);
		if (receivedLength < 0)
			return -1;
		if (receivedLength == 0)
			return 0;
		host->receivedData = host->packetData[0];
		host->receivedDataLength = receivedLength;
		host->totalReceivedData += receivedLength;
		host->totalReceivedPackets++;
		if (host->intercept != NULL) {
			switch (host->intercept->vtbl->run(host->intercept, host, event_)) {
			case 1:
				if (event_ != NULL && event_->type != ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
					return 1;
				continue;
			case -1:
				return -1;
			default:
				break;
			}
		}
		switch (ENet_enet_protocol_handle_incoming_commands(self, host, event_)) {
		case 1:
			return 1;
		case -1:
			return -1;
		default:
			break;
		}
	}
}

int ENet_enet_protocol_remove_sent_reliable_command(ENet const *self, ENetPeer *peer, ushort reliableSequenceNumber, unsigned char channelID)
{
	ENetOutgoingCommand *outgoingCommand = NULL;
	ENetListNode const *currentCommand;
	int commandNumber;
	int wasSent = 1;
	for (currentCommand = ENet_enet_list_begin(self, peer->sentReliableCommands); currentCommand != ENet_enet_list_end(self, peer->sentReliableCommands); currentCommand = ENet_enet_list_next(self, currentCommand)) {
		outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &currentCommand->base);
		if (outgoingCommand->reliableSequenceNumber == reliableSequenceNumber && outgoingCommand->command->header->channelID == channelID)
			break;
	}
	if (currentCommand == ENet_enet_list_end(self, peer->sentReliableCommands)) {
		for (currentCommand = ENet_enet_list_begin(self, peer->outgoingReliableCommands); currentCommand != ENet_enet_list_end(self, peer->outgoingReliableCommands); currentCommand = ENet_enet_list_next(self, currentCommand)) {
			outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &currentCommand->base);
			if (outgoingCommand->sendAttempts < 1)
				return 0;
			if (outgoingCommand->reliableSequenceNumber == reliableSequenceNumber && outgoingCommand->command->header->channelID == channelID)
				break;
		}
		if (currentCommand == ENet_enet_list_end(self, peer->outgoingReliableCommands))
			return 0;
		wasSent = 0;
	}
	if (outgoingCommand == NULL)
		return 0;
	if (channelID < peer->channelCount) {
		ENetChannel *channel = peer->channels[channelID];
		ushort reliableWindow = self->p->vtbl->intToUshort(self->p, reliableSequenceNumber / 4096);
		if (channel->reliableWindows[reliableWindow] > 0) {
			channel->reliableWindows[reliableWindow]--;
			if (channel->reliableWindows[reliableWindow] == 0)
				channel->usedReliableWindows &= ~(1 << reliableWindow);
		}
	}
	commandNumber = outgoingCommand->command->header->command & 15;
	ENet_enet_list_remove(self, ENetOutgoingCommand_outgoingCommandList(outgoingCommand));
	if (outgoingCommand->packet != NULL) {
		if (wasSent != 0)
			peer->reliableDataInTransit -= outgoingCommand->fragmentLength;
		outgoingCommand->packet->referenceCount--;
		if (outgoingCommand->packet->referenceCount == 0) {
			outgoingCommand->packet->flags |= 256;
			ENet_enet_packet_destroy(self, outgoingCommand->packet);
		}
	}
	free(outgoingCommand);
	if (ENet_enet_list_empty(self, peer->sentReliableCommands))
		return commandNumber;
	outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &ENet_enet_list_front(self, peer->sentReliableCommands)->base);
	peer->nextTimeout = outgoingCommand->sentTime + outgoingCommand->roundTripTimeout;
	return commandNumber;
}

void ENet_enet_protocol_remove_sent_unreliable_commands(ENet const *self, ENetPeer const *peer)
{
	ENetOutgoingCommand *outgoingCommand;
	while (!ENet_enet_list_empty(self, peer->sentUnreliableCommands)) {
		outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &ENet_enet_list_front(self, peer->sentUnreliableCommands)->base);
		ENet_enet_list_remove(self, ENetOutgoingCommand_outgoingCommandList(outgoingCommand));
		if (outgoingCommand->packet != NULL) {
			outgoingCommand->packet->referenceCount--;
			if (outgoingCommand->packet->referenceCount == 0) {
				outgoingCommand->packet->flags |= 256;
				ENet_enet_packet_destroy(self, outgoingCommand->packet);
			}
		}
		free(outgoingCommand);
	}
}

static void ENet_enet_protocol_send_acknowledgements(ENet const *self, ENetHost *host, ENetPeer *peer)
{
	int commandI = host->commandCount;
	int bufferI = host->bufferCount;
	ENetAcknowledgement *acknowledgement;
	ENetListNode const *currentAcknowledgement;
	ushort reliableSequenceNumber;
	currentAcknowledgement = ENet_enet_list_begin(self, peer->acknowledgements);
	while (currentAcknowledgement != ENet_enet_list_end(self, peer->acknowledgements)) {
		if (commandI >= 32 || bufferI >= 65 || peer->mtu - host->packetSize < 8) {
			host->continueSending = 1;
			break;
		}
		acknowledgement = self->p->vtbl->castToENetAcknowledgement(self->p, currentAcknowledgement);
		currentAcknowledgement = ENet_enet_list_next(self, currentAcknowledgement);
		if (self->test1 == 1) {
		}
		reliableSequenceNumber = ENet_ENET_HOST_TO_NET_16(self, acknowledgement->command->header->reliableSequenceNumber);
		host->commands[commandI]->header->command = 1;
		host->commands[commandI]->header->channelID = acknowledgement->command->header->channelID;
		host->commands[commandI]->header->reliableSequenceNumber = reliableSequenceNumber;
		host->commands[commandI]->acknowledge = ENetProtocolAcknowledge_New();
		host->commands[commandI]->acknowledge->receivedReliableSequenceNumber = reliableSequenceNumber;
		host->commands[commandI]->acknowledge->receivedSentTime = ENet_ENET_HOST_TO_NET_16(self, self->p->vtbl->intToUshort(self->p, acknowledgement->sentTime));
		unsigned char *buf = (unsigned char *) malloc(128 * sizeof(unsigned char ));
		ENet_SerializeCommand(self, buf, host->commands[commandI]);
		host->buffers[bufferI]->data = buf;
		host->buffers[bufferI]->dataLength = 8;
		host->packetSize += host->buffers[bufferI]->dataLength;
		if ((acknowledgement->command->header->command & 15) == 4)
			ENet_enet_protocol_dispatch_state(self, host, peer, 9);
		ENet_enet_list_remove(self, ENetAcknowledgement_acknowledgementList(acknowledgement));
		free(acknowledgement);
		commandI++;
		bufferI++;
	}
	host->commandCount = commandI;
	host->bufferCount = bufferI;
}

int ENet_enet_protocol_send_outgoing_commands(ENet *self, ENetHost *host, ENetEvent *event_, int checkForTimeouts)
{
	unsigned char *headerData = (unsigned char *) malloc(8 * sizeof(unsigned char ));
	ENetProtocolHeader *header = ENetProtocolHeader_New();
	ENetPeer *currentPeer;
	int sentLength;
	int shouldCompress = 0;
	host->continueSending = 1;
	while (host->continueSending != 0) {
		host->continueSending = 0;
		for (int i = 0; i < host->peerCount; i++) {
			if (self->test1 == 1) {
			}
			currentPeer = host->peers[i];
			if (currentPeer->state == 0 || currentPeer->state == 9)
				continue;
			host->headerFlags = 0;
			host->commandCount = 0;
			host->bufferCount = 1;
			host->packetSize = 4;
			if (!ENet_enet_list_empty(self, currentPeer->acknowledgements))
				ENet_enet_protocol_send_acknowledgements(self, host, currentPeer);
			if (checkForTimeouts != 0 && !ENet_enet_list_empty(self, currentPeer->sentReliableCommands) && ENet_ENET_TIME_GREATER_EQUAL(self, host->serviceTime, currentPeer->nextTimeout) && ENet_enet_protocol_check_timeouts(self, host, currentPeer, event_) == 1) {
				if (event_ != NULL && event_->type != ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E)
					return 1;
				else
					continue;
			}
			if ((ENet_enet_list_empty(self, currentPeer->outgoingReliableCommands) || ENet_enet_protocol_send_reliable_outgoing_commands(self, host, currentPeer) != 0) && ENet_enet_list_empty(self, currentPeer->sentReliableCommands) && ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, currentPeer->lastReceiveTime) >= currentPeer->pingInterval && currentPeer->mtu - host->packetSize >= 4) {
				ENet_enet_peer_ping(self, currentPeer);
				ENet_enet_protocol_send_reliable_outgoing_commands(self, host, currentPeer);
			}
			if (!ENet_enet_list_empty(self, currentPeer->outgoingUnreliableCommands))
				ENet_enet_protocol_send_unreliable_outgoing_commands(self, host, currentPeer);
			if (host->commandCount == 0)
				continue;
			if (currentPeer->packetLossEpoch == 0)
				currentPeer->packetLossEpoch = host->serviceTime;
			else if (ENet_ENET_TIME_DIFFERENCE(self, host->serviceTime, currentPeer->packetLossEpoch) >= 10000 && currentPeer->packetsSent > 0) {
				int packetLoss = currentPeer->packetsLost * 65536 / currentPeer->packetsSent;
				currentPeer->packetLossVariance -= currentPeer->packetLossVariance / 4;
				if (packetLoss >= currentPeer->packetLoss) {
					currentPeer->packetLoss += (packetLoss - currentPeer->packetLoss) / 8;
					currentPeer->packetLossVariance += (packetLoss - currentPeer->packetLoss) / 4;
				}
				else {
					currentPeer->packetLoss -= (currentPeer->packetLoss - packetLoss) / 8;
					currentPeer->packetLossVariance += (currentPeer->packetLoss - packetLoss) / 4;
				}
				currentPeer->packetLossEpoch = host->serviceTime;
				currentPeer->packetsSent = 0;
				currentPeer->packetsLost = 0;
			}
			host->buffers[0]->data = headerData;
			if ((host->headerFlags & 32768) != 0) {
				header->sentTime = ENet_ENET_HOST_TO_NET_16(self, self->p->vtbl->intToUshort(self->p, host->serviceTime & 65535));
				host->buffers[0]->dataLength = 4;
			}
			else {
				host->buffers[0]->dataLength = 2;
			}
			shouldCompress = 0;
			if (host->compressor != NULL) {
			}
			if (currentPeer->outgoingPeerID < 4095)
				host->headerFlags |= self->p->vtbl->intToUshort(self->p, currentPeer->outgoingSessionID << 12);
			header->peerID = ENet_ENET_HOST_TO_NET_16(self, self->p->vtbl->intToUshort(self->p, currentPeer->outgoingPeerID | host->headerFlags));
			ENet_SerializeHeader(self, headerData, header);
			if (host->checksum != NULL) {
			}
			if (shouldCompress > 0) {
				host->buffers[1]->data = host->packetData[1];
				host->buffers[1]->dataLength = shouldCompress;
				host->bufferCount = 2;
			}
			currentPeer->lastSendTime = host->serviceTime;
			sentLength = self->p->vtbl->enet_socket_send(self->p, host->socket, currentPeer->address, host->buffers, host->bufferCount);
			ENet_enet_protocol_remove_sent_unreliable_commands(self, currentPeer);
			if (sentLength < 0)
				return -1;
			host->totalSentData += sentLength;
			host->totalSentPackets++;
		}
	}
	return 0;
}

int ENet_enet_protocol_send_reliable_outgoing_commands(ENet *self, ENetHost *host, ENetPeer *peer)
{
	int commandI = host->commandCount;
	int bufferI = host->bufferCount;
	ENetOutgoingCommand *outgoingCommand;
	ENetListNode const *currentCommand;
	ENetChannel *channel;
	ushort reliableWindow;
	int commandSize;
	int windowExceeded = 0;
	int windowWrap = 0;
	int canPing = 1;
	currentCommand = ENet_enet_list_begin(self, peer->outgoingReliableCommands);
	if (self->test1 == 1) {
		self->test1 = self->test1;
	}
	while (currentCommand != ENet_enet_list_end(self, peer->outgoingReliableCommands)) {
		outgoingCommand = self->p->vtbl->castToENetOutgoingCommand(self->p, &currentCommand->base);
		channel = outgoingCommand->command->header->channelID < peer->channelCount ? peer->channels[outgoingCommand->command->header->channelID] : NULL;
		reliableWindow = self->p->vtbl->intToUshort(self->p, outgoingCommand->reliableSequenceNumber / 4096);
		if (channel != NULL) {
			if (windowWrap == 0 && outgoingCommand->sendAttempts < 1 && outgoingCommand->reliableSequenceNumber % 4096 == 0 && (channel->reliableWindows[(reliableWindow + 16 - 1) % 16] >= 4096 || (channel->usedReliableWindows & ((255 << reliableWindow) | (255 >> (4096 - reliableWindow)))) != 0))
				windowWrap = 1;
			if (windowWrap != 0) {
				currentCommand = ENet_enet_list_next(self, currentCommand);
				continue;
			}
		}
		if (outgoingCommand->packet != NULL) {
			if (windowExceeded == 0) {
				int windowSize = peer->packetThrottle * peer->windowSize / 32;
				if (peer->reliableDataInTransit + outgoingCommand->fragmentLength > ENet_ENET_MAX(self, windowSize, peer->mtu))
					windowExceeded = 1;
			}
			if (windowExceeded != 0) {
				currentCommand = ENet_enet_list_next(self, currentCommand);
				continue;
			}
		}
		canPing = 0;
		commandSize = self->commandSizes[outgoingCommand->command->header->command & 15];
		if (commandI > host->commandCount || bufferI > host->bufferCount || peer->mtu - host->packetSize < commandSize || (outgoingCommand->packet != NULL && ENet_ToUint16(self, peer->mtu - host->packetSize) < ENet_ToUint16(self, commandSize + outgoingCommand->fragmentLength))) {
			host->continueSending = 1;
			break;
		}
		currentCommand = ENet_enet_list_next(self, currentCommand);
		if (channel != NULL && outgoingCommand->sendAttempts < 1) {
			channel->usedReliableWindows |= 1 << reliableWindow;
			channel->reliableWindows[reliableWindow]++;
		}
		outgoingCommand->sendAttempts++;
		if (outgoingCommand->roundTripTimeout == 0) {
			outgoingCommand->roundTripTimeout = peer->roundTripTime + 4 * peer->roundTripTimeVariance;
			outgoingCommand->roundTripTimeoutLimit = peer->timeoutLimit * outgoingCommand->roundTripTimeout;
		}
		if (ENet_enet_list_empty(self, peer->sentReliableCommands))
			peer->nextTimeout = host->serviceTime + outgoingCommand->roundTripTimeout;
		ENet_enet_list_insert(self, ENet_enet_list_end(self, peer->sentReliableCommands), &ENet_enet_list_remove(self, ENetOutgoingCommand_outgoingCommandList(outgoingCommand))->base);
		outgoingCommand->sentTime = host->serviceTime;
		ENetProtocol *command = outgoingCommand->command;
		host->commands[commandI] = command;
		host->buffers[bufferI]->data = (unsigned char *) malloc(commandSize * sizeof(unsigned char ));
		ENet_SerializeCommand(self, host->buffers[bufferI]->data, host->commands[commandI]);
		host->buffers[bufferI]->dataLength = commandSize;
		host->packetSize += host->buffers[bufferI]->dataLength;
		host->headerFlags |= 32768;
		if (outgoingCommand->packet != NULL) {
			bufferI++;
			unsigned char *data = (unsigned char *) malloc(outgoingCommand->packet->dataLength * sizeof(unsigned char ));
			for (int i = 0; i < outgoingCommand->packet->dataLength - outgoingCommand->fragmentOffset; i++) {
				data[i] = outgoingCommand->packet->data[i + outgoingCommand->fragmentOffset];
			}
			host->buffers[bufferI]->data = data;
			host->buffers[bufferI]->dataLength = outgoingCommand->fragmentLength;
			host->packetSize += outgoingCommand->fragmentLength;
			peer->reliableDataInTransit += outgoingCommand->fragmentLength;
		}
		peer->packetsSent++;
		commandI++;
		bufferI++;
	}
	host->commandCount = commandI;
	host->bufferCount = bufferI;
	return canPing;
}

void ENet_enet_protocol_send_unreliable_outgoing_commands(ENet const *self, ENetHost const *host, ENetPeer const *peer)
{
}

static ENetIncomingCommand const *ENet_freePacket(ENet const *self, int fragmentCount, ENetPacket *packet)
{
	if (fragmentCount > 0)
		return ENet_notifyError(self, packet);
	if (packet != NULL && packet->referenceCount == 0)
		ENet_enet_packet_destroy(self, packet);
	return self->dummyCommand;
}

static void ENet_initialize_crc32(ENet *self)
{
	self->crcTable = (int *) malloc(256 * sizeof(int ));
	int byte_;
	int c = -2147483647;
	c -= 1;
	for (byte_ = 0; byte_ < 256; byte_++) {
		int crc = ENet_reflect_crc(byte_, 8) << 24;
		int offset;
		for (offset = 0; offset < 8; offset++) {
			if ((crc & c) != 0)
				crc = (crc << 1) ^ 79764919;
			else
				crc <<= 1;
		}
		self->crcTable[byte_] = ENet_reflect_crc(crc, 32);
	}
	self->initializedCRC32 = true;
}

static void ENet_memcpy(ENet const *self, unsigned char *destination, unsigned char const *source, int num)
{
	for (int i = 0; i < num; i++) {
		destination[i] = source[i];
	}
}

static ENetIncomingCommand const *ENet_notifyError(ENet const *self, ENetPacket *packet)
{
	if (packet != NULL && packet->referenceCount == 0)
		ENet_enet_packet_destroy(self, packet);
	return NULL;
}

static int ENet_reflect_crc(int val, int bits)
{
	int result = 0;
	int bit;
	for (bit = 0; bit < bits; bit++) {
		if ((val & 1) != 0)
			result |= 1 << (bits - 1 - bit);
		val >>= 1;
	}
	return result;
}

ENetAcknowledgement *ENetAcknowledgement_New(void)
{
	ENetAcknowledgement *self = (ENetAcknowledgement *) malloc(sizeof(ENetAcknowledgement));
	return self;
}

void ENetAcknowledgement_Delete(ENetAcknowledgement *self)
{
	free(self);
}

ENetListNode const *ENetAcknowledgement_acknowledgementList(ENetAcknowledgement const *self)
{
	return &self->base;
}

ENetAddress *ENetAddress_New(void)
{
	ENetAddress *self = (ENetAddress *) malloc(sizeof(ENetAddress));
	return self;
}

void ENetAddress_Delete(ENetAddress *self)
{
	free(self);
}

ENetAddress *ENetAddress_Clone(ENetAddress const *address)
{
	ENetAddress *other = ENetAddress_New();
	other->host = address->host;
	other->port = address->port;
	return other;
}

ENetBuffer *ENetBuffer_New(void)
{
	ENetBuffer *self = (ENetBuffer *) malloc(sizeof(ENetBuffer));
	return self;
}

void ENetBuffer_Delete(ENetBuffer *self)
{
	free(self);
}

static void ENetChannel_Construct(ENetChannel *self)
{
	self->reliableWindows = (int *) malloc(16 * sizeof(int ));
	self->incomingReliableCommands = ENetList_New();
	self->incomingUnreliableCommands = ENetList_New();
}

ENetChannel *ENetChannel_New(void)
{
	ENetChannel *self = (ENetChannel *) malloc(sizeof(ENetChannel));
	if (self != NULL)
		ENetChannel_Construct(self);
	return self;
}

void ENetChannel_Delete(ENetChannel *self)
{
	free(self);
}

static void ENetChecksumCallback_Construct(ENetChecksumCallback *self, const ENetChecksumCallbackVtbl *vtbl)
{
	self->vtbl = vtbl;
}

static void ENetCompressor_Construct(ENetCompressor *self, const ENetCompressorVtbl *vtbl)
{
	self->vtbl = vtbl;
}

ENetEvent *ENetEvent_New(void)
{
	ENetEvent *self = (ENetEvent *) malloc(sizeof(ENetEvent));
	return self;
}

void ENetEvent_Delete(ENetEvent *self)
{
	free(self);
}

static void ENetHost_Construct(ENetHost *self)
{
	self->address = ENetAddress_New();
	self->commands = (ENetProtocol const **) malloc(32 * sizeof(ENetProtocol const *));
	for (int i = 0; i < 32; i++) {
		self->commands[i] = ENetProtocol_New();
	}
	self->buffers = (ENetBuffer const **) malloc(65 * sizeof(ENetBuffer const *));
	for (int i = 0; i < 65; i++) {
		self->buffers[i] = ENetBuffer_New();
	}
	for (int i = 0; i < 65; i++) {
		self->buffers[i] = ENetBuffer_New();
	}
	self->dispatchQueue = &ENetPeer_New()->base;
	self->packetData = (unsigned char const **) malloc(2 * sizeof(unsigned char const *));
	self->packetData[0] = (unsigned char *) malloc(4096 * sizeof(unsigned char ));
	self->packetData[1] = (unsigned char *) malloc(4096 * sizeof(unsigned char ));
}

ENetHost *ENetHost_New(void)
{
	ENetHost *self = (ENetHost *) malloc(sizeof(ENetHost));
	if (self != NULL)
		ENetHost_Construct(self);
	return self;
}

void ENetHost_Delete(ENetHost *self)
{
	free(self);
}

ENetIncomingCommand *ENetIncomingCommand_New(void)
{
	ENetIncomingCommand *self = (ENetIncomingCommand *) malloc(sizeof(ENetIncomingCommand));
	return self;
}

void ENetIncomingCommand_Delete(ENetIncomingCommand *self)
{
	free(self);
}

ENetListNode const *ENetIncomingCommand_incomingCommandList(ENetIncomingCommand const *self)
{
	return &self->base;
}

static void ENetInterceptCallback_Construct(ENetInterceptCallback *self, const ENetInterceptCallbackVtbl *vtbl)
{
	self->vtbl = vtbl;
}

static void ENetList_Construct(ENetList *self)
{
	ENetList_SetSentinel(self, &ENetListNode_New()->base);
}

ENetList *ENetList_New(void)
{
	ENetList *self = (ENetList *) malloc(sizeof(ENetList));
	if (self != NULL)
		ENetList_Construct(self);
	return self;
}

void ENetList_Delete(ENetList *self)
{
	free(self);
}

ENetObject const *ENetList_GetSentinel(ENetList const *self)
{
	return self->base.next;
}

void ENetList_SetSentinel(ENetList *self, ENetObject const *value)
{
	self->base.next = value;
}

ENetListNode *ENetListNode_New(void)
{
	ENetListNode *self = (ENetListNode *) malloc(sizeof(ENetListNode));
	return self;
}

void ENetListNode_Delete(ENetListNode *self)
{
	free(self);
}

ENetOutgoingCommand *ENetOutgoingCommand_New(void)
{
	ENetOutgoingCommand *self = (ENetOutgoingCommand *) malloc(sizeof(ENetOutgoingCommand));
	return self;
}

void ENetOutgoingCommand_Delete(ENetOutgoingCommand *self)
{
	free(self);
}

ENetListNode const *ENetOutgoingCommand_outgoingCommandList(ENetOutgoingCommand const *self)
{
	return &self->base;
}

ENetPacket *ENetPacket_New(void)
{
	ENetPacket *self = (ENetPacket *) malloc(sizeof(ENetPacket));
	return self;
}

void ENetPacket_Delete(ENetPacket *self)
{
	free(self);
}

unsigned char const *ENetPacket_GetData(ENetPacket const *self)
{
	return self->data;
}

int ENetPacket_GetDataLength(ENetPacket const *self)
{
	return self->dataLength;
}

int ENetPacket_GetFlags(ENetPacket const *self)
{
	return self->flags;
}

ENetPacketFreeCallback const *ENetPacket_GetFreeCallback(ENetPacket const *self)
{
	return self->freeCallback;
}

int ENetPacket_GetReferenceCount(ENetPacket const *self)
{
	return self->referenceCount;
}

UserData const *ENetPacket_GetUserData(ENetPacket const *self)
{
	return self->userData;
}

void ENetPacket_SetData(ENetPacket *self, unsigned char *value)
{
	self->data = value;
}

void ENetPacket_SetDataLength(ENetPacket *self, int value)
{
	self->dataLength = value;
}

void ENetPacket_SetFlags(ENetPacket *self, int value)
{
	self->flags = value;
}

void ENetPacket_SetFreeCallback(ENetPacket *self, ENetPacketFreeCallback const *value)
{
	self->freeCallback = value;
}

void ENetPacket_SetReferenceCount(ENetPacket *self, int value)
{
	self->referenceCount = value;
}

void ENetPacket_SetUserData(ENetPacket *self, UserData const *value)
{
	self->userData = value;
}

static void ENetPacketFreeCallback_Construct(ENetPacketFreeCallback *self, const ENetPacketFreeCallbackVtbl *vtbl)
{
	self->vtbl = vtbl;
}

static void ENetPeer_Construct(ENetPeer *self)
{
	ENetList_Construct(&self->base);
	self->acknowledgements = ENetList_New();
	self->sentReliableCommands = ENetList_New();
	self->sentUnreliableCommands = ENetList_New();
	self->outgoingReliableCommands = ENetList_New();
	self->outgoingUnreliableCommands = ENetList_New();
	self->dispatchedCommands = ENetList_New();
	self->unsequencedWindow = (int *) malloc(32 * sizeof(int ));
}

ENetPeer *ENetPeer_New(void)
{
	ENetPeer *self = (ENetPeer *) malloc(sizeof(ENetPeer));
	if (self != NULL)
		ENetPeer_Construct(self);
	return self;
}

void ENetPeer_Delete(ENetPeer *self)
{
	free(self);
}

static ENetListNode const *ENetPeer_dispatchList(ENetPeer const *self)
{
	return &self->base.base;
}

static void ENetPlatform_Construct(ENetPlatform *self, const ENetPlatformVtbl *vtbl)
{
	self->vtbl = vtbl;
}

static void ENetProtocol_Construct(ENetProtocol *self)
{
	self->header = ENetProtocolCommandHeader_New();
}

ENetProtocol *ENetProtocol_New(void)
{
	ENetProtocol *self = (ENetProtocol *) malloc(sizeof(ENetProtocol));
	if (self != NULL)
		ENetProtocol_Construct(self);
	return self;
}

void ENetProtocol_Delete(ENetProtocol *self)
{
	free(self);
}

ENetProtocolAcknowledge *ENetProtocolAcknowledge_New(void)
{
	ENetProtocolAcknowledge *self = (ENetProtocolAcknowledge *) malloc(sizeof(ENetProtocolAcknowledge));
	return self;
}

void ENetProtocolAcknowledge_Delete(ENetProtocolAcknowledge *self)
{
	free(self);
}

ENetProtocolBandwidthLimit *ENetProtocolBandwidthLimit_New(void)
{
	ENetProtocolBandwidthLimit *self = (ENetProtocolBandwidthLimit *) malloc(sizeof(ENetProtocolBandwidthLimit));
	return self;
}

void ENetProtocolBandwidthLimit_Delete(ENetProtocolBandwidthLimit *self)
{
	free(self);
}

ENetProtocolCommandHeader *ENetProtocolCommandHeader_New(void)
{
	ENetProtocolCommandHeader *self = (ENetProtocolCommandHeader *) malloc(sizeof(ENetProtocolCommandHeader));
	return self;
}

void ENetProtocolCommandHeader_Delete(ENetProtocolCommandHeader *self)
{
	free(self);
}

ENetProtocolConnect *ENetProtocolConnect_New(void)
{
	ENetProtocolConnect *self = (ENetProtocolConnect *) malloc(sizeof(ENetProtocolConnect));
	return self;
}

void ENetProtocolConnect_Delete(ENetProtocolConnect *self)
{
	free(self);
}

ENetProtocolDisconnect *ENetProtocolDisconnect_New(void)
{
	ENetProtocolDisconnect *self = (ENetProtocolDisconnect *) malloc(sizeof(ENetProtocolDisconnect));
	return self;
}

void ENetProtocolDisconnect_Delete(ENetProtocolDisconnect *self)
{
	free(self);
}

ENetProtocolHeader *ENetProtocolHeader_New(void)
{
	ENetProtocolHeader *self = (ENetProtocolHeader *) malloc(sizeof(ENetProtocolHeader));
	return self;
}

void ENetProtocolHeader_Delete(ENetProtocolHeader *self)
{
	free(self);
}

ENetProtocolSendFragment *ENetProtocolSendFragment_New(void)
{
	ENetProtocolSendFragment *self = (ENetProtocolSendFragment *) malloc(sizeof(ENetProtocolSendFragment));
	return self;
}

void ENetProtocolSendFragment_Delete(ENetProtocolSendFragment *self)
{
	free(self);
}

ENetProtocolSendReliable *ENetProtocolSendReliable_New(void)
{
	ENetProtocolSendReliable *self = (ENetProtocolSendReliable *) malloc(sizeof(ENetProtocolSendReliable));
	return self;
}

void ENetProtocolSendReliable_Delete(ENetProtocolSendReliable *self)
{
	free(self);
}

ENetProtocolSendUnreliable *ENetProtocolSendUnreliable_New(void)
{
	ENetProtocolSendUnreliable *self = (ENetProtocolSendUnreliable *) malloc(sizeof(ENetProtocolSendUnreliable));
	return self;
}

void ENetProtocolSendUnreliable_Delete(ENetProtocolSendUnreliable *self)
{
	free(self);
}

ENetProtocolSendUnsequenced *ENetProtocolSendUnsequenced_New(void)
{
	ENetProtocolSendUnsequenced *self = (ENetProtocolSendUnsequenced *) malloc(sizeof(ENetProtocolSendUnsequenced));
	return self;
}

void ENetProtocolSendUnsequenced_Delete(ENetProtocolSendUnsequenced *self)
{
	free(self);
}

ENetProtocolThrottleConfigure *ENetProtocolThrottleConfigure_New(void)
{
	ENetProtocolThrottleConfigure *self = (ENetProtocolThrottleConfigure *) malloc(sizeof(ENetProtocolThrottleConfigure));
	return self;
}

void ENetProtocolThrottleConfigure_Delete(ENetProtocolThrottleConfigure *self)
{
	free(self);
}

ENetProtocolVerifyConnect *ENetProtocolVerifyConnect_New(void)
{
	ENetProtocolVerifyConnect *self = (ENetProtocolVerifyConnect *) malloc(sizeof(ENetProtocolVerifyConnect));
	return self;
}

void ENetProtocolVerifyConnect_Delete(ENetProtocolVerifyConnect *self)
{
	free(self);
}

static void ENetSocket_Construct(ENetSocket *self, const ENetSocketVtbl *vtbl)
{
	self->vtbl = vtbl;
}

ENetSymbol *ENetSymbol_New(void)
{
	ENetSymbol *self = (ENetSymbol *) malloc(sizeof(ENetSymbol));
	return self;
}

void ENetSymbol_Delete(ENetSymbol *self)
{
	free(self);
}

bool Math_isLessThanUnsigned(int n1, int n2)
{
	bool comp = n1 < n2;
	if (n1 < 0 != n2 < 0) {
		comp = !comp;
	}
	return comp;
}
