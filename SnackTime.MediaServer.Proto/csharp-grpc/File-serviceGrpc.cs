// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/file-service/file-service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SnackTime.MediaServer.Service.File {
  public static partial class File
  {
    static readonly string __ServiceName = "snacktime.file.service.File";

    static readonly grpc::Marshaller<global::SnackTime.MediaServer.Service.File.DownloadFileRequest> __Marshaller_snacktime_file_service_DownloadFileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SnackTime.MediaServer.Service.File.DownloadFileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SnackTime.MediaServer.Service.File.ResponseDownloadFile> __Marshaller_snacktime_file_service_ResponseDownloadFile = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SnackTime.MediaServer.Service.File.ResponseDownloadFile.Parser.ParseFrom);

    static readonly grpc::Method<global::SnackTime.MediaServer.Service.File.DownloadFileRequest, global::SnackTime.MediaServer.Service.File.ResponseDownloadFile> __Method_Download = new grpc::Method<global::SnackTime.MediaServer.Service.File.DownloadFileRequest, global::SnackTime.MediaServer.Service.File.ResponseDownloadFile>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Download",
        __Marshaller_snacktime_file_service_DownloadFileRequest,
        __Marshaller_snacktime_file_service_ResponseDownloadFile);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SnackTime.MediaServer.Service.File.FileServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of File</summary>
    public abstract partial class FileBase
    {
      public virtual global::System.Threading.Tasks.Task Download(global::SnackTime.MediaServer.Service.File.DownloadFileRequest request, grpc::IServerStreamWriter<global::SnackTime.MediaServer.Service.File.ResponseDownloadFile> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for File</summary>
    public partial class FileClient : grpc::ClientBase<FileClient>
    {
      /// <summary>Creates a new client for File</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FileClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for File that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FileClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FileClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FileClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::SnackTime.MediaServer.Service.File.ResponseDownloadFile> Download(global::SnackTime.MediaServer.Service.File.DownloadFileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Download(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::SnackTime.MediaServer.Service.File.ResponseDownloadFile> Download(global::SnackTime.MediaServer.Service.File.DownloadFileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Download, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FileClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FileClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FileBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Download, serviceImpl.Download).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FileBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Download, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::SnackTime.MediaServer.Service.File.DownloadFileRequest, global::SnackTime.MediaServer.Service.File.ResponseDownloadFile>(serviceImpl.Download));
    }

  }
}
#endregion
