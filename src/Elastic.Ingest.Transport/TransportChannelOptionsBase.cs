using Elastic.Transport;

namespace Elastic.Ingest.Transport
{
	public abstract class TransportChannelOptionsBase<TEvent, TResponse, TResponseItem, TBuffer>
		: ChannelOptionsBase<TEvent, TBuffer, TResponse, TResponseItem>
		where TBuffer : BufferOptions<TEvent>, new()
	{
		protected TransportChannelOptionsBase(ITransport<ITransportConfigurationValues> transport) => Transport = transport;

		public ITransport<ITransportConfigurationValues> Transport { get; }
	}
}
