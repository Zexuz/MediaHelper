// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SnackTime.Series.ProtoGenerated {

  /// <summary>Holder for reflection information generated from types.proto</summary>
  public static partial class TypesReflection {

    #region Descriptor
    /// <summary>File descriptor for types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgt0eXBlcy5wcm90byJnCgZTZXJpZXMSCgoCaWQYASABKAUSDQoFdGl0bGUY",
            "AiABKAkSHQoJaW1hZ2VzVXJsGAMgASgLMgouSW1hZ2VzVXJsEhAKCG92ZXJ2",
            "aWV3GAQgASgJEhEKCW1vbml0b3JlZBgFIAEoCCI7CglJbWFnZXNVcmwSDgoG",
            "YmFubmVyGAEgASgJEg4KBmZhbmFydBgCIAEoCRIOCgZwb3N0ZXIYAyABKAlC",
            "IqoCH1NuYWNrVGltZS5TZXJpZXMuUHJvdG9HZW5lcmF0ZWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.Series.ProtoGenerated.Series), global::SnackTime.Series.ProtoGenerated.Series.Parser, new[]{ "Id", "Title", "ImagesUrl", "Overview", "Monitored" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SnackTime.Series.ProtoGenerated.ImagesUrl), global::SnackTime.Series.ProtoGenerated.ImagesUrl.Parser, new[]{ "Banner", "Fanart", "Poster" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Series : pb::IMessage<Series> {
    private static readonly pb::MessageParser<Series> _parser = new pb::MessageParser<Series>(() => new Series());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Series> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.Series.ProtoGenerated.TypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Series() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Series(Series other) : this() {
      id_ = other.id_;
      title_ = other.title_;
      imagesUrl_ = other.imagesUrl_ != null ? other.imagesUrl_.Clone() : null;
      overview_ = other.overview_;
      monitored_ = other.monitored_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Series Clone() {
      return new Series(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "imagesUrl" field.</summary>
    public const int ImagesUrlFieldNumber = 3;
    private global::SnackTime.Series.ProtoGenerated.ImagesUrl imagesUrl_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SnackTime.Series.ProtoGenerated.ImagesUrl ImagesUrl {
      get { return imagesUrl_; }
      set {
        imagesUrl_ = value;
      }
    }

    /// <summary>Field number for the "overview" field.</summary>
    public const int OverviewFieldNumber = 4;
    private string overview_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Overview {
      get { return overview_; }
      set {
        overview_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "monitored" field.</summary>
    public const int MonitoredFieldNumber = 5;
    private bool monitored_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Monitored {
      get { return monitored_; }
      set {
        monitored_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Series);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Series other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Title != other.Title) return false;
      if (!object.Equals(ImagesUrl, other.ImagesUrl)) return false;
      if (Overview != other.Overview) return false;
      if (Monitored != other.Monitored) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (imagesUrl_ != null) hash ^= ImagesUrl.GetHashCode();
      if (Overview.Length != 0) hash ^= Overview.GetHashCode();
      if (Monitored != false) hash ^= Monitored.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (imagesUrl_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ImagesUrl);
      }
      if (Overview.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Overview);
      }
      if (Monitored != false) {
        output.WriteRawTag(40);
        output.WriteBool(Monitored);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (imagesUrl_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ImagesUrl);
      }
      if (Overview.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Overview);
      }
      if (Monitored != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Series other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.imagesUrl_ != null) {
        if (imagesUrl_ == null) {
          imagesUrl_ = new global::SnackTime.Series.ProtoGenerated.ImagesUrl();
        }
        ImagesUrl.MergeFrom(other.ImagesUrl);
      }
      if (other.Overview.Length != 0) {
        Overview = other.Overview;
      }
      if (other.Monitored != false) {
        Monitored = other.Monitored;
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
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            if (imagesUrl_ == null) {
              imagesUrl_ = new global::SnackTime.Series.ProtoGenerated.ImagesUrl();
            }
            input.ReadMessage(imagesUrl_);
            break;
          }
          case 34: {
            Overview = input.ReadString();
            break;
          }
          case 40: {
            Monitored = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ImagesUrl : pb::IMessage<ImagesUrl> {
    private static readonly pb::MessageParser<ImagesUrl> _parser = new pb::MessageParser<ImagesUrl>(() => new ImagesUrl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImagesUrl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SnackTime.Series.ProtoGenerated.TypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImagesUrl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImagesUrl(ImagesUrl other) : this() {
      banner_ = other.banner_;
      fanart_ = other.fanart_;
      poster_ = other.poster_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImagesUrl Clone() {
      return new ImagesUrl(this);
    }

    /// <summary>Field number for the "banner" field.</summary>
    public const int BannerFieldNumber = 1;
    private string banner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Banner {
      get { return banner_; }
      set {
        banner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fanart" field.</summary>
    public const int FanartFieldNumber = 2;
    private string fanart_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Fanart {
      get { return fanart_; }
      set {
        fanart_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "poster" field.</summary>
    public const int PosterFieldNumber = 3;
    private string poster_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Poster {
      get { return poster_; }
      set {
        poster_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImagesUrl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ImagesUrl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Banner != other.Banner) return false;
      if (Fanart != other.Fanart) return false;
      if (Poster != other.Poster) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Banner.Length != 0) hash ^= Banner.GetHashCode();
      if (Fanart.Length != 0) hash ^= Fanart.GetHashCode();
      if (Poster.Length != 0) hash ^= Poster.GetHashCode();
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
      if (Banner.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Banner);
      }
      if (Fanart.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Fanart);
      }
      if (Poster.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Poster);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Banner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Banner);
      }
      if (Fanart.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Fanart);
      }
      if (Poster.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Poster);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ImagesUrl other) {
      if (other == null) {
        return;
      }
      if (other.Banner.Length != 0) {
        Banner = other.Banner;
      }
      if (other.Fanart.Length != 0) {
        Fanart = other.Fanart;
      }
      if (other.Poster.Length != 0) {
        Poster = other.Poster;
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
          case 10: {
            Banner = input.ReadString();
            break;
          }
          case 18: {
            Fanart = input.ReadString();
            break;
          }
          case 26: {
            Poster = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
