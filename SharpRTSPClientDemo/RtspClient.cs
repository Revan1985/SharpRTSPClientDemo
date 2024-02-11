using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Rtsp;
using Rtsp.Messages;
using Rtsp.Rtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SharpRTSPClientDemo
{
    internal class RtspClient(ILoggerFactory? loggerFactory)
    {
        private readonly ILogger? _logger = loggerFactory?.CreateLogger<RtspClient>() as ILogger ?? NullLogger.Instance;
        private readonly ILoggerFactory? _loggerFactory = loggerFactory;

        public enum RTP_TRANSPORT
        {
            UDP,
            TCP,
            MULTICAST
        };

        [Flags]
        public enum MEDIA_REQUEST
        {
            VIDEO_ONLY = 1,
            AUDIO_ONLY = 2,
            VIDEO_AND_AUDIO = VIDEO_ONLY | AUDIO_ONLY
        };
        private enum RTSP_STATUS
        {
            WaitingToConnect,
            Connecting,
            ConnectFailed,
            Connected
        };



        public event EventHandler<SpsPpsEventArgs>? ReceivedSpsPps;
        public event EventHandler<VpsSpsPpsEventArgs>? ReceivedVpsSpsPps;
        public event EventHandler<SimpleDataEventArgs>? ReceivedNALs; // H264 or H265
        public event EventHandler<SimpleDataEventArgs>? ReceivedMp2t;
        public event EventHandler<SimpleDataEventArgs>? ReceivedJpeg;
        public event EventHandler<G711EventArgs>? ReceivedG711;
        public event EventHandler<AMREventArgs>? ReceivedAMR;
        public event EventHandler<AACEventArgs>? ReceivedAAC;

        IRtspTransport? _rtspSocket;
        RTSP_STATUS _rtspStatus = RTSP_STATUS.WaitingToConnect;
        RTP_TRANSPORT _rtpTransport = RTP_TRANSPORT.UDP;
        RtspListener? _rtspListener;

        UDPSocket? _videoUdpPair;
        UDPSocket? _audioUdpPair;

        Uri? _uri;
        string _session = string.Empty;

        private Authentication? _authentication;
        private NetworkCredential _networkCredential = new();

        private readonly uint ssrc = 12345;

        private bool _clientWantsAudio = false;
        private bool _clientWantsVideo = false;

        private Uri? _videoUri = null;
        private int _videoPayload = -1;
        private bool h264SpsPpsFired = false;
        private bool h265VpsSpsPpsFired = false;

        private Uri? _audioUri = null;
        private int _audioPayload = -1;
        private string _audioCodec = string.Empty;

        private bool _serverSupportsGetParameter = false;
        private System.Timers.Timer? _keepAliveTimer = null;

        IPayloadProcessor? _videoPayloadProcessor = null;
        IPayloadProcessor? _audioPayloadProcessor = null;

        private readonly Queue<RtspRequestSetup> _setupMessages = [];
    }
}
