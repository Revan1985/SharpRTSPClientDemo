namespace SharpRTSPClientDemo;

public class SpsPpsEventArgs(byte[] sps, byte[] pps) : EventArgs
{
    public byte[] Sps { get; } = sps;
    public byte[] Pps { get; } = pps;
}

public class VpsSpsPpsEventArgs(byte[] vps, byte[] sps, byte[] pps) : EventArgs
{
    public byte[] Vps { get; } = vps;
    public byte[] Sps { get; } = sps;
    public byte[] Pps { get; } = pps;
}

public class SimpleDataEventArgs(IEnumerable<ReadOnlyMemory<byte>> data) : EventArgs
{
    public IEnumerable<ReadOnlyMemory<byte>> Data { get; } = data;
}

public class G711EventArgs(string format, IEnumerable<ReadOnlyMemory<byte>> data) : EventArgs
{
    public string Format { get; } = format;
    public IEnumerable<ReadOnlyMemory<byte>> Data { get; } = data;
}

public class AMREventArgs(string format, IEnumerable<ReadOnlyMemory<byte>> data) : EventArgs
{
    public string Format { get; } = format;
    public IEnumerable<ReadOnlyMemory<byte>> Data { get; } = data;
}

public class AACEventArgs(string format, IEnumerable<ReadOnlyMemory<byte>> data, int objectType, int frequencyIndex, int channelConfiguration) : EventArgs
{
    public string Format { get; } = format;
    public IEnumerable<ReadOnlyMemory<byte>> Data { get; } = data;
    public int ObjectType { get; } = objectType;
    public int FrequencyIndex { get; } = frequencyIndex;
    public int ChannelConfiguration { get; } = channelConfiguration;
}