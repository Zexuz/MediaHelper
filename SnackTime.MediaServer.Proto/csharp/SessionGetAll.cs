// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/serssion-service/session-getAll.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SnackTime.MediaServer.Service.Session {

  /// <summary>Holder for reflection information generated from proto/serssion-service/session-getAll.proto</summary>
  public static partial class SessionGetAllReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/serssion-service/session-getAll.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionGetAllReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citwcm90by9zZXJzc2lvbi1zZXJ2aWNlL3Nlc3Npb24tZ2V0QWxsLnByb3Rv",
            "EhhzbmFja3RpbWUuc2VyaWVzLnNlc3Npb24aE3Byb3RvL3N0b3JhZ2UucHJv",
            "dG8iDwoNR2V0QWxsUmVxdWVzdCI+Cg5HZXRBbGxSZXNwb25zZRIsCghzZXNz",
            "aW9ucxgBIAMoCzIaLnNuYWNrdGltZS5zdG9yYWdlLlNlc3Npb25CKKoCJVNu",
            "YWNrVGltZS5NZWRpYVNlcnZlci5TZXJ2aWNlLlNlc3Npb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::SnackTime.MediaServer.Storage.ProtoGenerated.StorageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.MediaServer.Service.Session.GetAllRequest), global::SnackTime.MediaServer.Service.Session.GetAllRequest.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.MediaServer.Service.Session.GetAllResponse), global::SnackTime.MediaServer.Service.Session.GetAllResponse.Parser, new[]{ "Sessions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetAllRequest : pb::IMessage<GetAllRequest> {
    private static readonly pb::MessageParser<GetAllRequest> _parser = new pb::MessageParser<GetAllRequest>(() => new GetAllRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.MediaServer.Service.Session.SessionGetAllReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest(GetAllRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllRequest Clone() {
      return new GetAllRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

  }

  public sealed partial class GetAllResponse : pb::IMessage<GetAllResponse> {
    private static readonly pb::MessageParser<GetAllResponse> _parser = new pb::MessageParser<GetAllResponse>(() => new GetAllResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.MediaServer.Service.Session.SessionGetAllReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllResponse(GetAllResponse other) : this() {
      sessions_ = other.sessions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAllResponse Clone() {
      return new GetAllResponse(this);
    }

    /// <summary>Field number for the "sessions" field.</summary>
    public const int SessionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::SnackTime.MediaServer.Storage.ProtoGenerated.Session> _repeated_sessions_codec
        = pb::FieldCodec.ForMessage(10, global::SnackTime.MediaServer.Storage.ProtoGenerated.Session.Parser);
    private readonly pbc::RepeatedField<global::SnackTime.MediaServer.Storage.ProtoGenerated.Session> sessions_ = new pbc::RepeatedField<global::SnackTime.MediaServer.Storage.ProtoGenerated.Session>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SnackTime.MediaServer.Storage.ProtoGenerated.Session> Sessions {
      get { return sessions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessions_.Equals(other.sessions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessions_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sessions_.WriteTo(output, _repeated_sessions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sessions_.CalculateSize(_repeated_sessions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAllResponse other) {
      if (other == null) {
        return;
      }
      sessions_.Add(other.sessions_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            sessions_.AddEntriesFrom(input, _repeated_sessions_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
