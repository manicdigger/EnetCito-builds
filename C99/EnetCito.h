// Generated automatically with "cito". Do not edit.
#ifndef _ENETCITO_H_
#define _ENETCITO_H_
#include <stdbool.h>
#ifdef __cplusplus
extern "C" {
#endif
typedef struct Byte Byte;
typedef struct ENet ENet;
typedef struct ENetAcknowledgement ENetAcknowledgement;
typedef struct ENetAddress ENetAddress;
typedef struct ENetBuffer ENetBuffer;
typedef struct ENetChannel ENetChannel;
typedef struct ENetChecksumCallback ENetChecksumCallback;
typedef struct ENetCompressor ENetCompressor;
typedef struct ENetEvent ENetEvent;

typedef enum {
	ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__N_O_N_E,
	ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__C_O_N_N_E_C_T,
	ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__D_I_S_C_O_N_N_E_C_T,
	ENetEventType_E_N_E_T__E_V_E_N_T__T_Y_P_E__R_E_C_E_I_V_E
}
ENetEventType;
typedef struct ENetHost ENetHost;
typedef struct ENetIncomingCommand ENetIncomingCommand;
typedef struct ENetInterceptCallback ENetInterceptCallback;
typedef struct ENetList ENetList;
typedef struct ENetListNode ENetListNode;
typedef struct ENetOutgoingCommand ENetOutgoingCommand;
typedef struct ENetPacket ENetPacket;
typedef struct ENetPacketFreeCallback ENetPacketFreeCallback;
typedef struct ENetPeer ENetPeer;
typedef struct ENetPlatform ENetPlatform;
typedef struct ENetProtocol ENetProtocol;
typedef struct ENetProtocolAcknowledge ENetProtocolAcknowledge;
typedef struct ENetProtocolBandwidthLimit ENetProtocolBandwidthLimit;
typedef struct ENetProtocolCommandHeader ENetProtocolCommandHeader;
typedef struct ENetProtocolConnect ENetProtocolConnect;
typedef struct ENetProtocolDisconnect ENetProtocolDisconnect;
typedef struct ENetProtocolHeader ENetProtocolHeader;
typedef struct ENetProtocolSendFragment ENetProtocolSendFragment;
typedef struct ENetProtocolSendReliable ENetProtocolSendReliable;
typedef struct ENetProtocolSendUnreliable ENetProtocolSendUnreliable;
typedef struct ENetProtocolSendUnsequenced ENetProtocolSendUnsequenced;
typedef struct ENetProtocolThrottleConfigure ENetProtocolThrottleConfigure;
typedef struct ENetProtocolVerifyConnect ENetProtocolVerifyConnect;
typedef struct ENetSocket ENetSocket;
typedef struct ENetSymbol ENetSymbol;
typedef struct Test Test;

Byte *Byte_New(void);
void Byte_Delete(Byte *self);

ENet *ENet_New(void);
void ENet_Delete(ENet *self);

#define ENet_E_N_E_T__B_U_F_F_E_R__M_A_X_I_M_U_M  65

#define ENet_E_N_E_T__H_O_S_T__A_N_Y  0

#define ENet_E_N_E_T__H_O_S_T__B_A_N_D_W_I_D_T_H__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L  1000

#define ENet_E_N_E_T__H_O_S_T__B_R_O_A_D_C_A_S_T  -1

#define ENet_E_N_E_T__H_O_S_T__D_E_F_A_U_L_T__M_T_U  1400

#define ENet_E_N_E_T__H_O_S_T__R_E_C_E_I_V_E__B_U_F_F_E_R__S_I_Z_E  262144

#define ENet_E_N_E_T__H_O_S_T__S_E_N_D__B_U_F_F_E_R__S_I_Z_E  262144

#define ENet_E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__P_A_C_K_E_T__T_H_R_O_T_T_L_E  32

#define ENet_E_N_E_T__P_E_E_R__D_E_F_A_U_L_T__R_O_U_N_D__T_R_I_P__T_I_M_E  500

#define ENet_E_N_E_T__P_E_E_R__F_R_E_E__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S  8

#define ENet_E_N_E_T__P_E_E_R__F_R_E_E__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S  32

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__I_N_T_E_R_V_A_L  10000

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__L_O_S_S__S_C_A_L_E  65536

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__A_C_C_E_L_E_R_A_T_I_O_N  2

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__C_O_U_N_T_E_R  7

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__D_E_C_E_L_E_R_A_T_I_O_N  2

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__I_N_T_E_R_V_A_L  5000

#define ENet_E_N_E_T__P_E_E_R__P_A_C_K_E_T__T_H_R_O_T_T_L_E__S_C_A_L_E  32

#define ENet_E_N_E_T__P_E_E_R__P_I_N_G__I_N_T_E_R_V_A_L  500

#define ENet_E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W_S  16

#define ENet_E_N_E_T__P_E_E_R__R_E_L_I_A_B_L_E__W_I_N_D_O_W__S_I_Z_E  4096

#define ENet_E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__L_I_M_I_T  32

#define ENet_E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_A_X_I_M_U_M  30000

#define ENet_E_N_E_T__P_E_E_R__T_I_M_E_O_U_T__M_I_N_I_M_U_M  5000

#define ENet_E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W_S  64

#define ENet_E_N_E_T__P_E_E_R__U_N_S_E_Q_U_E_N_C_E_D__W_I_N_D_O_W__S_I_Z_E  1024

#define ENet_E_N_E_T__P_E_E_R__W_I_N_D_O_W__S_I_Z_E__S_C_A_L_E  65536

#define ENet_E_N_E_T__P_O_R_T__A_N_Y  0

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__A_C_K_N_O_W_L_E_D_G_E  1

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__B_A_N_D_W_I_D_T_H__L_I_M_I_T  10

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_N_N_E_C_T  2

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__C_O_U_N_T  13

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__D_I_S_C_O_N_N_E_C_T  4

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__A_C_K_N_O_W_L_E_D_G_E  128

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D  64

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__M_A_S_K  15

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__N_O_N_E  0

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__P_I_N_G  5

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__F_R_A_G_M_E_N_T  8

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__R_E_L_I_A_B_L_E  6

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E  7

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T  12

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__S_E_N_D__U_N_S_E_Q_U_E_N_C_E_D  9

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__T_H_R_O_T_T_L_E__C_O_N_F_I_G_U_R_E  11

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__C_O_M_M_A_N_D__V_E_R_I_F_Y__C_O_N_N_E_C_T  3

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__C_O_M_P_R_E_S_S_E_D  16384

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__M_A_S_K  49152

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__F_L_A_G__S_E_N_T__T_I_M_E  32768

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__M_A_S_K  12288

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__H_E_A_D_E_R__S_E_S_S_I_O_N__S_H_I_F_T  12

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T  255

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__F_R_A_G_M_E_N_T__C_O_U_N_T  1048576

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__M_T_U  4096

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__C_O_M_M_A_N_D_S  32

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_A_C_K_E_T__S_I_Z_E  1073741824

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__P_E_E_R__I_D  4095

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_A_X_I_M_U_M__W_I_N_D_O_W__S_I_Z_E  32768

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__C_H_A_N_N_E_L__C_O_U_N_T  1

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__M_T_U  576

#define ENet_E_N_E_T__P_R_O_T_O_C_O_L__M_I_N_I_M_U_M__W_I_N_D_O_W__S_I_Z_E  4096

#define ENet_E_N_E_T__S_O_C_K_E_T__W_A_I_T__I_N_T_E_R_R_U_P_T  4

#define ENet_E_N_E_T__S_O_C_K_E_T__W_A_I_T__N_O_N_E  0

#define ENet_E_N_E_T__S_O_C_K_E_T__W_A_I_T__R_E_C_E_I_V_E  2

#define ENet_E_N_E_T__S_O_C_K_E_T__W_A_I_T__S_E_N_D  1

int ENet_ENET_VERSION(void);

int ENet_ENET_VERSION_CREATE(int major, int minor, int patch);

int ENet_ENET_VERSION_GET_MAJOR(int version);

int ENet_ENET_VERSION_GET_MINOR(int version);

int ENet_ENET_VERSION_GET_PATCH(int version);

#define ENet_E_N_E_T__V_E_R_S_I_O_N__M_A_J_O_R  1

#define ENet_E_N_E_T__V_E_R_S_I_O_N__M_I_N_O_R  3

#define ENet_E_N_E_T__V_E_R_S_I_O_N__P_A_T_C_H  8

#define ENet_S_O_C_K_E_T__E_R_R_O_R  -1

void ENet_SetPlatform(ENet *self, ENetPlatform const *value);

unsigned char ENet_ToByte(int a);

int ENet_enet_address_set_host(ENet const *self, ENetAddress const *address, const char *hostName);

int ENet_enet_crc32(ENet *self, ENetBuffer const *const *buffers, int bufferCount);

void ENet_enet_deinitialize(ENet const *self);

/**
 * Adjusts the bandwidth limits of a host.
 * @remarks the incoming and outgoing bandwidth parameters are identical in function to those
 * specified in enet_host_create().
 * @param host host to adjust
 * @param incomingBandwidth new incoming bandwidth
 * @param outgoingBandwidth new outgoing bandwidth
 */
void ENet_enet_host_bandwidth_limit(ENet const *self, ENetHost *host, int incomingBandwidth, int outgoingBandwidth);

/**
 * Queues a packet to be sent to all peers associated with the host.
 * @param host host on which to broadcast the packet
 * @param channelID channel on which to broadcast
 * @param packet packet to broadcast
 */
void ENet_enet_host_broadcast(ENet const *self, ENetHost const *host, unsigned char channelID, ENetPacket *packet);

/**
 * Limits the maximum allowed channels of future incoming connections.
 * @param host host to limit
 * @param channelLimit the maximum number of channels allowed; if 0, then this is equivalent to ENET_PROTOCOL_MAXIMUM_CHANNEL_COUNT
 */
void ENet_enet_host_channel_limit(ENet const *self, ENetHost *host, int channelLimit);

/**
 * Checks for any queued events on the host and dispatches one if available.
 * @retval &gt; 0 if an event was dispatched
 * @retval 0 if no events are available
 * @retval &lt; 0 on failure
 * @ingroup host
 * @param host host to check for events
 * @param event_ an event structure where event details will be placed if available
 */
int ENet_enet_host_check_events(ENet const *self, ENetHost *host, ENetEvent *event_);

/**
 * Sets the packet compressor the host should use to compress and decompress packets.
 * @param host host to enable or disable compression for
 * @param compressor callbacks for for the packet compressor; if NULL, then compression is disabled
 */
void ENet_enet_host_compress(ENet const *self, ENetHost *host, ENetCompressor const *compressor);

/**
 * Sets the packet compressor the host should use to the default range coder.
 * @returns 0 on success, &lt; 0 on failure
 * @param host @param host host to enable the range coder for
 */
int ENet_enet_host_compress_with_range_coder(ENet const *self, ENetHost const *host);

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
ENetPeer const *ENet_enet_host_connect(ENet const *self, ENetHost *host, ENetAddress const *address, int channelCount, int data);

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
ENetHost const *ENet_enet_host_create(ENet const *self, ENetAddress const *address, int peerCount, int channelLimit, int incomingBandwidth, int outgoingBandwidth);

/**
 * Destroys the host and all resources associated with it.
 * @param host pointer to the host to destroy
 */
void ENet_enet_host_destroy(ENet const *self, ENetHost *host);

/**
 * Sends any queued packets on the host specified to its designated peers.
 * @remarks this function need only be used in circumstances where one wishes to send queued packets earlier than in a call to enet_host_service().
 * @ingroup host
 * @param host host to flush
 */
void ENet_enet_host_flush(ENet *self, ENetHost *host);

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
int ENet_enet_host_service(ENet *self, ENetHost *host, ENetEvent *event_, int timeout);

int ENet_enet_initialize(ENet const *self);

/**
 * Creates a packet that may be sent to a peer.
 * @returns the packet on success, NULL on failure
 * @param data initial contents of the packet's data; the packet's data will remain uninitialized if dataContents is NULL.
 * @param dataLength size of the data allocated for this packet
 * @param flags flags for this packet as described for the ENetPacket structure.
 */
ENetPacket *ENet_enet_packet_create(ENet const *self, unsigned char *data, int dataLength, int flags);

/**
 * Destroys the packet and deallocates its data.
 * @param packet packet to be destroyed
 */
void ENet_enet_packet_destroy(ENet const *self, ENetPacket *packet);

int ENet_enet_packet_resize(ENet const *self, ENetPacket *packet, int dataLength);

/**
 * Request a disconnection from a peer.
 * An ENET_EVENT_DISCONNECT event will be generated by enet_host_service()
 * once the disconnection is complete.
 * @param peer peer to request a disconnection
 * @param data data describing the disconnection
 */
void ENet_enet_peer_disconnect(ENet *self, ENetPeer *peer, int data);

/**
 * Request a disconnection from a peer, but only after all queued outgoing packets are sent.
 * An ENET_EVENT_DISCONNECT event will be generated by enet_host_service()
 * once the disconnection is complete.
 * @param peer peer to request a disconnection
 * @param data data describing the disconnection
 */
void ENet_enet_peer_disconnect_later(ENet *self, ENetPeer *peer, int data);

/**
 * Force an immediate disconnection from a peer.
 * @remarks No ENET_EVENT_DISCONNECT event will be generated. The foreign peer is not
 * guarenteed to receive the disconnect notification, and is reset immediately upon
 * return from this function.
 * @param peer peer to disconnect
 * @param data data describing the disconnection
 */
void ENet_enet_peer_disconnect_now(ENet *self, ENetPeer *peer, int data);

/**
 * Sends a ping request to a peer.
 * ping requests factor into the mean round trip time as designated by the 
 * roundTripTime field in the ENetPeer structure.  Enet automatically pings all connected
 * peers at regular intervals, however, this function may be called to ensure more
 * frequent ping requests.
 * @param peer destination for the ping request
 */
void ENet_enet_peer_ping(ENet const *self, ENetPeer *peer);

/**
 * Sets the interval at which pings will be sent to a peer. 
 * Pings are used both to monitor the liveness of the connection and also to dynamically
 * adjust the throttle during periods of low traffic so that the throttle has reasonable
 * responsiveness during traffic spikes.
 * @param peer the peer to adjust
 * @param pingInterval the interval at which to send pings; defaults to ENET_PEER_PING_INTERVAL if 0
 */
void ENet_enet_peer_ping_interval(ENet const *self, ENetPeer *peer, int pingInterval);

/**
 * Attempts to dequeue any incoming queued packet.
 * @returns a pointer to the packet, or NULL if there are no available incoming queued packets
 * @param peer peer to dequeue packets from
 * @param channelID holds the channel ID of the channel the packet was received on success
 */
ENetPacket const *ENet_enet_peer_receive(ENet const *self, ENetPeer const *peer, Byte *channelID);

void ENet_enet_peer_remove_incoming_commands(ENet const *self, ENetList const *queue, ENetListNode const *startCommand, ENetListNode const *endCommand);

/**
 * Forcefully disconnects a peer.
 * The foreign host represented by the peer is not notified of the disconnection and will timeout
 * on its connection to the local host.
 * @param peer peer to forcefully disconnect
 */
void ENet_enet_peer_reset(ENet const *self, ENetPeer *peer);

void ENet_enet_peer_reset_incoming_commands(ENet const *self, ENetList const *queue);

void ENet_enet_peer_reset_outgoing_commands(ENet const *self, ENetList const *queue);

void ENet_enet_peer_reset_queues(ENet const *self, ENetPeer *peer);

/**
 * Queues a packet to be sent.
 * @retval 0 on success
 * @retval &lt; 0 on failure
 * @param peer destination for the packet
 * @param channelID channel on which to send
 * @param packet packet to send
 */
int ENet_enet_peer_send(ENet const *self, ENetPeer *peer, unsigned char channelID, ENetPacket *packet);

void ENet_enet_peer_setup_outgoing_command(ENet const *self, ENetPeer *peer, ENetOutgoingCommand *outgoingCommand);

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
void ENet_enet_peer_throttle_configure(ENet const *self, ENetPeer *peer, int interval, int acceleration, int deceleration);

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
void ENet_enet_peer_timeout(ENet const *self, ENetPeer *peer, int timeoutLimit, int timeoutMinimum, int timeoutMaximum);

void ENet_enet_protocol_change_state(ENet const *self, ENetHost const *host, ENetPeer *peer, int state);

int ENet_enet_protocol_check_timeouts(ENet const *self, ENetHost *host, ENetPeer *peer, ENetEvent *event_);

int ENet_enet_protocol_dispatch_incoming_commands(ENet const *self, ENetHost *host, ENetEvent *event_);

void ENet_enet_protocol_dispatch_state(ENet const *self, ENetHost const *host, ENetPeer *peer, int state);

int ENet_enet_protocol_handle_acknowledge(ENet *self, ENetHost *host, ENetEvent *event_, ENetPeer *peer, ENetProtocol const *command);

int ENet_enet_protocol_handle_bandwidth_limit(ENet const *self, ENetHost *host, ENetPeer *peer, ENetProtocol const *command);

ENetPeer *ENet_enet_protocol_handle_connect(ENet const *self, ENetHost const *host, ENetProtocolHeader const *header, ENetProtocol const *command);

int ENet_enet_protocol_handle_disconnect(ENet const *self, ENetHost *host, ENetPeer *peer, ENetProtocol const *command);

int ENet_enet_protocol_handle_incoming_commands(ENet *self, ENetHost *host, ENetEvent *event_);

int ENet_enet_protocol_handle_ping(ENet const *self, ENetHost const *host, ENetPeer const *peer, ENetProtocol const *command);

int ENet_enet_protocol_handle_send_fragment(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol const *command, unsigned char const *currentData, int *currentDataI);

int ENet_enet_protocol_handle_send_unreliable(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol *command, unsigned char const *currentData, int *currentDataI);

int ENet_enet_protocol_handle_send_unreliable_fragment(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol const *command, unsigned char const *currentData);

int ENet_enet_protocol_handle_send_unsequenced(ENet const *self, ENetHost const *host, ENetPeer const *peer, ENetProtocol const *command, unsigned char const *currentData);

int ENet_enet_protocol_handle_throttle_configure(ENet const *self, ENetHost const *host, ENetPeer *peer, ENetProtocol const *command);

int ENet_enet_protocol_handle_verify_connect(ENet const *self, ENetHost *host, ENetEvent *event_, ENetPeer *peer, ENetProtocol const *command);

void ENet_enet_protocol_notify_connect(ENet const *self, ENetHost *host, ENetPeer *peer, ENetEvent *event_);

void ENet_enet_protocol_notify_disconnect(ENet const *self, ENetHost *host, ENetPeer *peer, ENetEvent *event_);

int ENet_enet_protocol_receive_incoming_commands(ENet *self, ENetHost *host, ENetEvent *event_);

int ENet_enet_protocol_remove_sent_reliable_command(ENet const *self, ENetPeer *peer, int reliableSequenceNumber, unsigned char channelID);

void ENet_enet_protocol_remove_sent_unreliable_commands(ENet const *self, ENetPeer const *peer);

int ENet_enet_protocol_send_outgoing_commands(ENet *self, ENetHost *host, ENetEvent *event_, int checkForTimeouts);

int ENet_enet_protocol_send_reliable_outgoing_commands(ENet *self, ENetHost *host, ENetPeer *peer);

void ENet_enet_protocol_send_unreliable_outgoing_commands(ENet const *self, ENetHost const *host, ENetPeer const *peer);

ENetAcknowledgement *ENetAcknowledgement_New(void);
void ENetAcknowledgement_Delete(ENetAcknowledgement *self);

ENetListNode const *ENetAcknowledgement_acknowledgementList(ENetAcknowledgement const *self);

ENetAddress *ENetAddress_New(void);
void ENetAddress_Delete(ENetAddress *self);

ENetAddress *ENetAddress_Clone(ENetAddress const *address);

ENetBuffer *ENetBuffer_New(void);
void ENetBuffer_Delete(ENetBuffer *self);

ENetChannel *ENetChannel_New(void);
void ENetChannel_Delete(ENetChannel *self);

int ENetChannel_GetOutgoingReliableSequenceNumber(ENetChannel const *self);

void ENetChannel_SetOutgoingReliableSequenceNumber(ENetChannel *self, int value);

#define ENetChannel_RELIABLE_WINDOWS_LENGTH  16

ENetEvent *ENetEvent_New(void);
void ENetEvent_Delete(ENetEvent *self);

ENetHost *ENetHost_New(void);
void ENetHost_Delete(ENetHost *self);

#define ENetHost_BUFFERS_MAX_COUNT  65

#define ENetHost_COMMANDS_MAX_COUNT  32

#define ENetHost_PACKET_DATA0_SIZE_OF  4096

ENetIncomingCommand *ENetIncomingCommand_New(void);
void ENetIncomingCommand_Delete(ENetIncomingCommand *self);

ENetListNode const *ENetIncomingCommand_incomingCommandList(ENetIncomingCommand const *self);

ENetObject const *ENetList_GetSentinel(ENetList const *self);

void ENetList_SetSentinel(ENetList *self, ENetObject const *value);

ENetListNode *ENetListNode_New(void);
void ENetListNode_Delete(ENetListNode *self);

ENetOutgoingCommand *ENetOutgoingCommand_New(void);
void ENetOutgoingCommand_Delete(ENetOutgoingCommand *self);

ENetListNode const *ENetOutgoingCommand_outgoingCommandList(ENetOutgoingCommand const *self);

ENetPacket *ENetPacket_New(void);
void ENetPacket_Delete(ENetPacket *self);

unsigned char const *ENetPacket_GetData(ENetPacket const *self);

int ENetPacket_GetDataLength(ENetPacket const *self);

int ENetPacket_GetFlags(ENetPacket const *self);

ENetPacketFreeCallback const *ENetPacket_GetFreeCallback(ENetPacket const *self);

int ENetPacket_GetReferenceCount(ENetPacket const *self);

UserData const *ENetPacket_GetUserData(ENetPacket const *self);

void ENetPacket_SetData(ENetPacket *self, unsigned char *value);

void ENetPacket_SetDataLength(ENetPacket *self, int value);

void ENetPacket_SetFlags(ENetPacket *self, int value);

void ENetPacket_SetFreeCallback(ENetPacket *self, ENetPacketFreeCallback const *value);

void ENetPacket_SetReferenceCount(ENetPacket *self, int value);

void ENetPacket_SetUserData(ENetPacket *self, UserData const *value);

#define ENetPacketFlagEnum_E_N_E_T__P_A_C_K_E_T__F_L_A_G__N_O__A_L_L_O_C_A_T_E  4

#define ENetPacketFlagEnum_E_N_E_T__P_A_C_K_E_T__F_L_A_G__R_E_L_I_A_B_L_E  1

#define ENetPacketFlagEnum_E_N_E_T__P_A_C_K_E_T__F_L_A_G__S_E_N_T  256

#define ENetPacketFlagEnum_E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_R_E_L_I_A_B_L_E__F_R_A_G_M_E_N_T  8

#define ENetPacketFlagEnum_E_N_E_T__P_A_C_K_E_T__F_L_A_G__U_N_S_E_Q_U_E_N_C_E_D  2

ENetPeer *ENetPeer_New(void);
void ENetPeer_Delete(ENetPeer *self);

int ENetPeer_GetOutgoingReliableSequenceNumber(ENetPeer const *self);

void ENetPeer_SetOutgoingReliableSequenceNumber(ENetPeer *self, int value);

#define ENetPeer_UNSEQUENCED_WINDOW_LENGTH  32

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__C_O_N_N_E_C_T  2

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__A_C_K_N_O_W_L_E_D_G_I_N_G__D_I_S_C_O_N_N_E_C_T  8

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_E_D  5

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_N_G  1

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__P_E_N_D_I_N_G  3

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__C_O_N_N_E_C_T_I_O_N__S_U_C_C_E_E_D_E_D  4

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_E_D  0

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T_I_N_G  7

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__D_I_S_C_O_N_N_E_C_T__L_A_T_E_R  6

#define ENetPeerState_E_N_E_T__P_E_E_R__S_T_A_T_E__Z_O_M_B_I_E  9

ENetProtocol *ENetProtocol_New(void);
void ENetProtocol_Delete(ENetProtocol *self);

ENetProtocolAcknowledge *ENetProtocolAcknowledge_New(void);
void ENetProtocolAcknowledge_Delete(ENetProtocolAcknowledge *self);

#define ENetProtocolAcknowledge_SIZE_OF  8

ENetProtocolBandwidthLimit *ENetProtocolBandwidthLimit_New(void);
void ENetProtocolBandwidthLimit_Delete(ENetProtocolBandwidthLimit *self);

ENetProtocolCommandHeader *ENetProtocolCommandHeader_New(void);
void ENetProtocolCommandHeader_Delete(ENetProtocolCommandHeader *self);

#define ENetProtocolCommandHeader_SIZE_OF  4

ENetProtocolConnect *ENetProtocolConnect_New(void);
void ENetProtocolConnect_Delete(ENetProtocolConnect *self);

ENetProtocolDisconnect *ENetProtocolDisconnect_New(void);
void ENetProtocolDisconnect_Delete(ENetProtocolDisconnect *self);

ENetProtocolHeader *ENetProtocolHeader_New(void);
void ENetProtocolHeader_Delete(ENetProtocolHeader *self);

#define ENetProtocolHeader_SIZE_OF  4

#define ENetProtocolPing_SIZE_OF  4

ENetProtocolSendFragment *ENetProtocolSendFragment_New(void);
void ENetProtocolSendFragment_Delete(ENetProtocolSendFragment *self);

#define ENetProtocolSendFragment_SIZE_OF  28

ENetProtocolSendReliable *ENetProtocolSendReliable_New(void);
void ENetProtocolSendReliable_Delete(ENetProtocolSendReliable *self);

#define ENetProtocolSendReliable_SIZE_OF  6

ENetProtocolSendUnreliable *ENetProtocolSendUnreliable_New(void);
void ENetProtocolSendUnreliable_Delete(ENetProtocolSendUnreliable *self);

#define ENetProtocolSendUnreliable_SIZE_OF  12

ENetProtocolSendUnsequenced *ENetProtocolSendUnsequenced_New(void);
void ENetProtocolSendUnsequenced_Delete(ENetProtocolSendUnsequenced *self);

ENetProtocolThrottleConfigure *ENetProtocolThrottleConfigure_New(void);
void ENetProtocolThrottleConfigure_Delete(ENetProtocolThrottleConfigure *self);

ENetProtocolVerifyConnect *ENetProtocolVerifyConnect_New(void);
void ENetProtocolVerifyConnect_Delete(ENetProtocolVerifyConnect *self);

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__B_R_O_A_D_C_A_S_T  2

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__E_R_R_O_R  8

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__N_O_D_E_L_A_Y  9

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__N_O_N_B_L_O_C_K  1

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__R_C_V_B_U_F  3

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__R_C_V_T_I_M_E_O  6

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__R_E_U_S_E_A_D_D_R  5

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__S_N_D_B_U_F  4

#define ENetSocketOption_E_N_E_T__S_O_C_K_O_P_T__S_N_D_T_I_M_E_O  7

#define ENetSocketShutdown_E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D  0

#define ENetSocketShutdown_E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__R_E_A_D__W_R_I_T_E  2

#define ENetSocketShutdown_E_N_E_T__S_O_C_K_E_T__S_H_U_T_D_O_W_N__W_R_I_T_E  1

#define ENetSocketTypeEnum_E_N_E_T__S_O_C_K_E_T__T_Y_P_E__D_A_T_A_G_R_A_M  2

#define ENetSocketTypeEnum_E_N_E_T__S_O_C_K_E_T__T_Y_P_E__S_T_R_E_A_M  1

ENetSymbol *ENetSymbol_New(void);
void ENetSymbol_Delete(ENetSymbol *self);

bool Math_isLessThanUnsigned(int n1, int n2);

void Test_f(Test const *self);

#ifdef __cplusplus
}
#endif
#endif
