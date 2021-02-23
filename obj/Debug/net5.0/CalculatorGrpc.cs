// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

public static partial class Calculator
{
  static readonly string __ServiceName = "Calculator";

  static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (message is global::Google.Protobuf.IBufferMessage)
    {
      context.SetPayloadLength(message.CalculateSize());
      global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
      context.Complete();
      return;
    }
    #endif
    context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
  }

  static class __Helper_MessageCache<T>
  {
    public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
  }

  static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
  {
    #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
    if (__Helper_MessageCache<T>.IsBufferMessage)
    {
      return parser.ParseFrom(context.PayloadAsReadOnlySequence());
    }
    #endif
    return parser.ParseFrom(context.PayloadAsNewBuffer());
  }

  static readonly grpc::Marshaller<global::Number> __Marshaller_Number = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Number.Parser));

  static readonly grpc::Method<global::Number, global::Number> __Method_SquareRoot = new grpc::Method<global::Number, global::Number>(
      grpc::MethodType.Unary,
      __ServiceName,
      "SquareRoot",
      __Marshaller_Number,
      __Marshaller_Number);

  /// <summary>Service descriptor</summary>
  public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
  {
    get { return global::CalculatorReflection.Descriptor.Services[0]; }
  }

  /// <summary>Client for Calculator</summary>
  public partial class CalculatorClient : grpc::ClientBase<CalculatorClient>
  {
    /// <summary>Creates a new client for Calculator</summary>
    /// <param name="channel">The channel to use to make remote calls.</param>
    public CalculatorClient(grpc::ChannelBase channel) : base(channel)
    {
    }
    /// <summary>Creates a new client for Calculator that uses a custom <c>CallInvoker</c>.</summary>
    /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
    public CalculatorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
    {
    }
    /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
    protected CalculatorClient() : base()
    {
    }
    /// <summary>Protected constructor to allow creation of configured clients.</summary>
    /// <param name="configuration">The client configuration.</param>
    protected CalculatorClient(ClientBaseConfiguration configuration) : base(configuration)
    {
    }

    public virtual global::Number SquareRoot(global::Number request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return SquareRoot(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual global::Number SquareRoot(global::Number request, grpc::CallOptions options)
    {
      return CallInvoker.BlockingUnaryCall(__Method_SquareRoot, null, options, request);
    }
    public virtual grpc::AsyncUnaryCall<global::Number> SquareRootAsync(global::Number request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
    {
      return SquareRootAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
    }
    public virtual grpc::AsyncUnaryCall<global::Number> SquareRootAsync(global::Number request, grpc::CallOptions options)
    {
      return CallInvoker.AsyncUnaryCall(__Method_SquareRoot, null, options, request);
    }
    /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
    protected override CalculatorClient NewInstance(ClientBaseConfiguration configuration)
    {
      return new CalculatorClient(configuration);
    }
  }

}
#endregion