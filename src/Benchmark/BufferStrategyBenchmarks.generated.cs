﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MyContracts.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Hyper
{

    /// <summary>Holder for reflection information generated from MyContracts.proto</summary>
    public static partial class MyContractsReflection
    {

        #region Descriptor
        /// <summary>File descriptor for MyContracts.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static MyContractsReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "ChFNeUNvbnRyYWN0cy5wcm90bxIFSHlwZXIiJwoPTXVsdGlwbHlSZXF1ZXN0",
                  "EgkKAXgYASABKAUSCQoBeRgCIAEoBSIgCg5NdWx0aXBseVJlc3VsdBIOCgZy",
                  "ZXN1bHQYASABKAUiGgoJQnl0ZXNUZXN0Eg0KBXZhbHVlGAEgASgMMkcKCkNh",
                  "bGN1bGF0b3ISOQoITXVsdGlwbHkSFi5IeXBlci5NdWx0aXBseVJlcXVlc3Qa",
                  "FS5IeXBlci5NdWx0aXBseVJlc3VsdEIIqgIFSHlwZXJiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Hyper.BytesTest), global::Hyper.BytesTest.Parser, new[]{ "Value" }, null, null, null, null)
                }));
        }
        #endregion

    }
    #region Messages
    
    public sealed partial class BytesTest : pb::IMessage<BytesTest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
#endif
    {
        private static readonly pb::MessageParser<BytesTest> _parser = new pb::MessageParser<BytesTest>(() => new BytesTest());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<BytesTest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::Hyper.MyContractsReflection.Descriptor.MessageTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public BytesTest()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public BytesTest(BytesTest other) : this()
        {
            value_ = other.value_;
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public BytesTest Clone()
        {
            return new BytesTest(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private pb::ByteString value_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pb::ByteString Value
        {
            get { return value_; }
            set
            {
                value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other)
        {
            return Equals(other as BytesTest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(BytesTest other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (Value != other.Value) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Value.Length != 0) hash ^= Value.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output)
        {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
            output.WriteRawMessage(this);
#else
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
        {
            if (Value.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(Value);
            }
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(ref output);
            }
        }
#endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize()
        {
            int size = 0;
            if (Value.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
            }
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(BytesTest other)
        {
            if (other == null)
            {
                return;
            }
            if (other.Value.Length != 0)
            {
                Value = other.Value;
            }
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input)
        {
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
            Value = input.ReadBytes();
            break;
          }
        }
      }
#endif
        }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                        break;
                    case 10:
                        {
                            Value = input.ReadBytes();
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
