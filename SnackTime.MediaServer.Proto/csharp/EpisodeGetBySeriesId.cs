// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/episode-service/episode-getBySeriesId.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SnackTime.MediaServer.Service.Episode {

  /// <summary>Holder for reflection information generated from proto/episode-service/episode-getBySeriesId.proto</summary>
  public static partial class EpisodeGetBySeriesIdReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/episode-service/episode-getBySeriesId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EpisodeGetBySeriesIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFwcm90by9lcGlzb2RlLXNlcnZpY2UvZXBpc29kZS1nZXRCeVNlcmllc0lk",
            "LnByb3RvEhlzbmFja3RpbWUuZXBpc29kZS5zZXJ2aWNlGhFwcm90by9tZWRp",
            "YS5wcm90byIoChRHZXRCeVNlcmllc0lkUmVxdWVzdBIQCghzZXJpZXNJZBgB",
            "IAEoBSJDChVHZXRCeVNlcmllc0lkUmVzcG9uc2USKgoIZXBpc29kZXMYASAD",
            "KAsyGC5zbmFja3RpbWUubWVkaWEuRXBpc29kZUIoqgIlU25hY2tUaW1lLk1l",
            "ZGlhU2VydmVyLlNlcnZpY2UuRXBpc29kZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::SnackTime.MediaServer.Models.ProtoGenerated.MediaReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.MediaServer.Service.Episode.GetBySeriesIdRequest), global::SnackTime.MediaServer.Service.Episode.GetBySeriesIdRequest.Parser, new[]{ "SeriesId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.MediaServer.Service.Episode.GetBySeriesIdResponse), global::SnackTime.MediaServer.Service.Episode.GetBySeriesIdResponse.Parser, new[]{ "Episodes" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetBySeriesIdRequest : pb::IMessage<GetBySeriesIdRequest> {
    private static readonly pb::MessageParser<GetBySeriesIdRequest> _parser = new pb::MessageParser<GetBySeriesIdRequest>(() => new GetBySeriesIdRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetBySeriesIdRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.MediaServer.Service.Episode.EpisodeGetBySeriesIdReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBySeriesIdRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBySeriesIdRequest(GetBySeriesIdRequest other) : this() {
      seriesId_ = other.seriesId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBySeriesIdRequest Clone() {
      return new GetBySeriesIdRequest(this);
    }

    /// <summary>Field number for the "seriesId" field.</summary>
    public const int SeriesIdFieldNumber = 1;
    private int seriesId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SeriesId {
      get { return seriesId_; }
      set {
        seriesId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetBySeriesIdRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetBySeriesIdRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SeriesId != other.SeriesId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SeriesId != 0) hash ^= SeriesId.GetHashCode();
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
      if (SeriesId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SeriesId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SeriesId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SeriesId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetBySeriesIdRequest other) {
      if (other == null) {
        return;
      }
      if (other.SeriesId != 0) {
        SeriesId = other.SeriesId;
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
          case 8: {
            SeriesId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetBySeriesIdResponse : pb::IMessage<GetBySeriesIdResponse> {
    private static readonly pb::MessageParser<GetBySeriesIdResponse> _parser = new pb::MessageParser<GetBySeriesIdResponse>(() => new GetBySeriesIdResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetBySeriesIdResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.MediaServer.Service.Episode.EpisodeGetBySeriesIdReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBySeriesIdResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBySeriesIdResponse(GetBySeriesIdResponse other) : this() {
      episodes_ = other.episodes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBySeriesIdResponse Clone() {
      return new GetBySeriesIdResponse(this);
    }

    /// <summary>Field number for the "episodes" field.</summary>
    public const int EpisodesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::SnackTime.MediaServer.Models.ProtoGenerated.Episode> _repeated_episodes_codec
        = pb::FieldCodec.ForMessage(10, global::SnackTime.MediaServer.Models.ProtoGenerated.Episode.Parser);
    private readonly pbc::RepeatedField<global::SnackTime.MediaServer.Models.ProtoGenerated.Episode> episodes_ = new pbc::RepeatedField<global::SnackTime.MediaServer.Models.ProtoGenerated.Episode>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::SnackTime.MediaServer.Models.ProtoGenerated.Episode> Episodes {
      get { return episodes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetBySeriesIdResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetBySeriesIdResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!episodes_.Equals(other.episodes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= episodes_.GetHashCode();
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
      episodes_.WriteTo(output, _repeated_episodes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += episodes_.CalculateSize(_repeated_episodes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetBySeriesIdResponse other) {
      if (other == null) {
        return;
      }
      episodes_.Add(other.episodes_);
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
            episodes_.AddEntriesFrom(input, _repeated_episodes_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
