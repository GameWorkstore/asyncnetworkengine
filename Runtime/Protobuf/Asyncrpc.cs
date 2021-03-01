// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: asyncrpc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GameWorkstore.AsyncNetworkEngine {

  /// <summary>Holder for reflection information generated from asyncrpc.proto</summary>
  public static partial class AsyncrpcReflection {

    #region Descriptor
    /// <summary>File descriptor for asyncrpc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AsyncrpcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5hc3luY3JwYy5wcm90bxIgR2FtZVdvcmtzdG9yZS5Bc3luY05ldHdvcmtF",
            "bmdpbmUiIQoOR2VuZXJpY1JlcXVlc3QSDwoHTWVzc2VnZRgBIAEoCSIiCg9H",
            "ZW5lcmljUmVzcG9uc2USDwoHTWVzc2VnZRgCIAEoCSIlChRHZW5lcmljRXJy",
            "b3JSZXNwb25zZRINCgVFcnJvchgBIAEoCSohCg1DbG91ZFByb3ZpZGVyEgcK",
            "A0FXUxAAEgcKA0dDUBABKrABCgxUcmFuc21pc3Npb24SEAoMTm90U3BlY2lm",
            "aWVkEAASBwoCT2sQyAESFwoSTWFyc2hhbERlY29kZUVycm9yEKICEhcKEk1h",
            "cnNoYWxFbmNvZGVFcnJvchCjAhISCg1SZXNwb25zZVdyaXRlEKQCEhMKDk5v",
            "dEltcGxlbWVudGVkEKUCEhkKFEludGVybmFsSGFuZGxlckVycm9yEKYCEg8K",
            "Ck5vdEFsbG93ZWQQlQNCR0gDWkNnaXRodWIuY29tL0dhbWVXb3Jrc3RvcmUv",
            "YXN5bmMtbmV0d29yay1lbmdpbmUtZ287YXN5bmNuZXR3b3JrZW5naW5lYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GameWorkstore.AsyncNetworkEngine.CloudProvider), typeof(global::GameWorkstore.AsyncNetworkEngine.Transmission), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GameWorkstore.AsyncNetworkEngine.GenericRequest), global::GameWorkstore.AsyncNetworkEngine.GenericRequest.Parser, new[]{ "Messege" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GameWorkstore.AsyncNetworkEngine.GenericResponse), global::GameWorkstore.AsyncNetworkEngine.GenericResponse.Parser, new[]{ "Messege" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GameWorkstore.AsyncNetworkEngine.GenericErrorResponse), global::GameWorkstore.AsyncNetworkEngine.GenericErrorResponse.Parser, new[]{ "Error" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CloudProvider {
    [pbr::OriginalName("AWS")] Aws = 0,
    [pbr::OriginalName("GCP")] Gcp = 1,
  }

  public enum Transmission {
    [pbr::OriginalName("NotSpecified")] NotSpecified = 0,
    [pbr::OriginalName("Ok")] Ok = 200,
    [pbr::OriginalName("MarshalDecodeError")] MarshalDecodeError = 290,
    [pbr::OriginalName("MarshalEncodeError")] MarshalEncodeError = 291,
    [pbr::OriginalName("ResponseWrite")] ResponseWrite = 292,
    [pbr::OriginalName("NotImplemented")] NotImplemented = 293,
    [pbr::OriginalName("InternalHandlerError")] InternalHandlerError = 294,
    [pbr::OriginalName("NotAllowed")] NotAllowed = 405,
  }

  #endregion

  #region Messages
  public sealed partial class GenericRequest : pb::IMessage<GenericRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenericRequest> _parser = new pb::MessageParser<GenericRequest>(() => new GenericRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GenericRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameWorkstore.AsyncNetworkEngine.AsyncrpcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericRequest(GenericRequest other) : this() {
      messege_ = other.messege_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericRequest Clone() {
      return new GenericRequest(this);
    }

    /// <summary>Field number for the "Messege" field.</summary>
    public const int MessegeFieldNumber = 1;
    private string messege_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Messege {
      get { return messege_; }
      set {
        messege_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GenericRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GenericRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Messege != other.Messege) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Messege.Length != 0) hash ^= Messege.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Messege.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Messege);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Messege.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Messege);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Messege.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Messege);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GenericRequest other) {
      if (other == null) {
        return;
      }
      if (other.Messege.Length != 0) {
        Messege = other.Messege;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Messege = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Messege = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GenericResponse : pb::IMessage<GenericResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenericResponse> _parser = new pb::MessageParser<GenericResponse>(() => new GenericResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GenericResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameWorkstore.AsyncNetworkEngine.AsyncrpcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericResponse(GenericResponse other) : this() {
      messege_ = other.messege_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericResponse Clone() {
      return new GenericResponse(this);
    }

    /// <summary>Field number for the "Messege" field.</summary>
    public const int MessegeFieldNumber = 2;
    private string messege_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Messege {
      get { return messege_; }
      set {
        messege_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GenericResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GenericResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Messege != other.Messege) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Messege.Length != 0) hash ^= Messege.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Messege.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Messege);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Messege.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Messege);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Messege.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Messege);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GenericResponse other) {
      if (other == null) {
        return;
      }
      if (other.Messege.Length != 0) {
        Messege = other.Messege;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            Messege = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            Messege = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GenericErrorResponse : pb::IMessage<GenericErrorResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GenericErrorResponse> _parser = new pb::MessageParser<GenericErrorResponse>(() => new GenericErrorResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GenericErrorResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameWorkstore.AsyncNetworkEngine.AsyncrpcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericErrorResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericErrorResponse(GenericErrorResponse other) : this() {
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GenericErrorResponse Clone() {
      return new GenericErrorResponse(this);
    }

    /// <summary>Field number for the "Error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GenericErrorResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GenericErrorResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error.Length != 0) hash ^= Error.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Error.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Error.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GenericErrorResponse other) {
      if (other == null) {
        return;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Error = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Error = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code