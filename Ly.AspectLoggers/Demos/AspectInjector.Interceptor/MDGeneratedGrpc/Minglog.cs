﻿// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: minglog.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MD.Logger
{

    /// <summary>Holder for reflection information generated from minglog.proto</summary>
    public static partial class MinglogReflection
    {

        #region Descriptor
        /// <summary>File descriptor for minglog.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static MinglogReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "Cg1taW5nbG9nLnByb3RvEglNRC5Mb2dnZXIi7wIKB01pbmdMb2cSEQoJdGlt",
                  "ZVN0YW1wGAEgASgDEhAKCGhvc3ROYW1lGAIgASgJEisKC3NlcnZpY2VUeXBl",
                  "GAMgASgOMhYuTUQuTG9nZ2VyLlNlcnZpY2VUeXBlEicKCWRldmVsb3BlchgE",
                  "IAEoDjIULk1ELkxvZ2dlci5EZXZlbG9wZXISEAoIY2xpZW50SXAYBSABKAkS",
                  "DQoFc3RhY2sYBiABKAkSDwoHbWVzc2FnZRgHIAEoCRIOCgZhY3Rpb24YCCAB",
                  "KAkSEQoJYWNjb3VudElkGAkgASgJEhEKCXByb2plY3RJZBgKIAEoCRIiCgVs",
                  "ZXZlbBgLIAEoDjITLk1ELkxvZ2dlci5Mb2dMZXZlbBIuCgZleHRyYXMYDCAD",
                  "KAsyHi5NRC5Mb2dnZXIuTWluZ0xvZy5FeHRyYXNFbnRyeRotCgtFeHRyYXNF",
                  "bnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBIjEKDUV4ZWN1",
                  "dGVSZXN1bHQSEQoJaXNTdWNjZXNzGAEgASgIEg0KBWVycm9yGAIgASgJKj8K",
                  "CExvZ0xldmVsEgkKBURlYnVnEAASCAoESW5mbxABEggKBFdhcm4QAhIJCgVF",
                  "cnJvchADEgkKBUZhdGFsEAQqxQYKC1NlcnZpY2VUeXBlEgsKB1Vua25vd24Q",
                  "ABIKCgZNYXN0ZXIQARIHCgNBUEkQAhITCg9DYWxlbmRhclNlcnZpY2UQAxIU",
                  "ChBGb2xkZXJTdGF0aXN0aWNzEAQSIAocUmFiYml0TVFTb2xvckNvbnN1bWVy",
                  "U2VydmljZRAFEhYKEkVtYWlsU2VuZGVyU2VydmljZRAGEhQKEFNtc1NlbmRl",
                  "clNlcnZpY2UQBxILCgdXZWJIb29rEAgSDgoKQ2hhdFNvY2tldBAJEgsKB0No",
                  "YXRBcGkQChIMCghDaGF0SHR0cBALEg4KCkNoYXRBdmF0YXIQDBINCglDaGF0",
                  "UXVldWUQDRIKCgZNeU1haWwQDhISCg5NeU1haWxVcGxvYWRlchAPEhUKEU15",
                  "TWFpbEZpbGVTZXJ2aWNlEBASCgoGT3BUb29sEBESCwoHVHBMb2dpbhASEg0K",
                  "CVVybFBhcnNlchATEhMKD1dlaXhpbk1QU2VydmljZRAUEgYKAkxQEBUSDgoK",
                  "T3dhU2VydmljZRAWEhMKD1JlbGF0aW9uU2VydmljZRAXEgwKCENvdW50aW5n",
                  "EBgSFAoQQ291bnRpbmdJbnRlcm5hbBAZEg0KCVB1c2hRdWV1ZRAaEg4KClB1",
                  "c2hTZXJ2ZXIQGxIPCgtNZWV0aW5ncm9vbRAcEggKBE9wZW4QHRIMCghNRE1h",
                  "bmFnZRAeEgwKCEFwcHJvdmFsEB8SBgoCT0EQIBIJCgVNRENSTRAhEgkKBUNo",
                  "ZWNrECISGAoUQmFzZURhdGFDYWNoZVNlcnZpY2UQIxIPCgtCYXNlU2Vydmlj",
                  "ZRAkEhUKEVdvcmtXZWlYaW5TZXJ2aWNlECUSGAoUQXV0aG9yaXphdGlvblNl",
                  "cnZpY2UQJhIVChFEaXNjdXNzaW9uU2VydmljZRAnEg8KC1JvbGVTZXJ2aWNl",
                  "ECgSFAoQU3RydWN0dXJlU2VydmljZRApEhAKDEluYm94U2VydmljZRAqEhQK",
                  "EFdvcmtTaGVldFNlcnZpY2UQKxINCglFU1NlcnZpY2UQLBIQCgxHcm91cFNl",
                  "cnZpY2UQLRIVChFBdHRhY2htZW50U2VydmljZRAuEg8KC0Zvcm1TZXJ2aWNl",
                  "EC8q6AEKCURldmVsb3BlchINCglVbmRlZmluZWQQABIMCghSYXZlblpodRAB",
                  "EgwKCEplcnJ5SmluEAISCgoGRXJpY1l1EAMSCgoGU2luWm91EAQSDQoJV2Vs",
                  "bHNTaGVuEAUSDgoKQ2FybG9zZUdhbxAGEgkKBUxlb1d1EAcSDAoIVG9ieVlh",
                  "bmcQCBIOCgpSZW5uYm9uWmh1EAkSCwoHQmVja0ppbhAKEgwKCEFsbGVuU3Vu",
                  "EAsSDAoIU3VuY2hlbmcQDBILCgdMaWhlbGluEA0SDAoIRWR3YXJkTHUQDhIM",
                  "CghDaHJpc1N1bhAPMkgKCkxvZ1NlcnZpY2USOgoIV3JpdGVMb2cSEi5NRC5M",
                  "b2dnZXIuTWluZ0xvZxoYLk1ELkxvZ2dlci5FeGVjdXRlUmVzdWx0IgBCHwoN",
                  "bWQubG9nc2VydmljZUIGTG9nZ2VyUAGiAgNMTExiBnByb3RvMw=="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(new[] { typeof(global::MD.Logger.LogLevel), typeof(global::MD.Logger.ServiceType), typeof(global::MD.Logger.Developer), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MD.Logger.MingLog), global::MD.Logger.MingLog.Parser, new[]{ "TimeStamp", "HostName", "ServiceType", "Developer", "ClientIp", "Stack", "Message", "Action", "AccountId", "ProjectId", "Level", "Extras" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::MD.Logger.ExecuteResult), global::MD.Logger.ExecuteResult.Parser, new[]{ "IsSuccess", "Error" }, null, null, null)
                }));
        }
        #endregion

    }
    #region Enums
    /// <summary>
    /// 日志级别
    /// </summary>
    public enum LogLevel
    {
        /// <summary>
        /// 对调试应用程序是非常有帮助
        /// </summary>
        [pbr::OriginalName("Debug")] Debug = 0,
        /// <summary>
        /// 突出强调应用程序的运行过程
        /// </summary>
        [pbr::OriginalName("Info")] Info = 1,
        /// <summary>
        /// 会出现潜在错误的情形
        /// </summary>
        [pbr::OriginalName("Warn")] Warn = 2,
        /// <summary>
        /// 已出现的错误, 但不影响系统的继续运行
        /// </summary>
        [pbr::OriginalName("Error")] Error = 3,
        /// <summary>
        /// 严重的错误事件将会导致应用程序的退出
        /// </summary>
        [pbr::OriginalName("Fatal")] Fatal = 4,
    }

    /// <summary>
    /// 服务类型
    /// </summary>
    public enum ServiceType
    {
        /// <summary>
        /// 未知
        /// </summary>
        [pbr::OriginalName("Unknown")] Unknown = 0,
        /// <summary>
        /// 主站
        /// </summary>
        [pbr::OriginalName("Master")] Master = 1,
        /// <summary>
        /// API
        /// </summary>
        [pbr::OriginalName("API")] Api = 2,
        /// <summary>
        /// 日程Push服务
        /// </summary>
        [pbr::OriginalName("CalendarService")] CalendarService = 3,
        /// <summary>
        /// 项目统计服务
        /// </summary>
        [pbr::OriginalName("FolderStatistics")] FolderStatistics = 4,
        /// <summary>
        /// RabbitMQ Solor 消费端服务
        /// </summary>
        [pbr::OriginalName("RabbitMQSolorConsumerService")] RabbitMqsolorConsumerService = 5,
        /// <summary>
        /// 邮件服务
        /// </summary>
        [pbr::OriginalName("EmailSenderService")] EmailSenderService = 6,
        /// <summary>
        /// 短信服务
        /// </summary>
        [pbr::OriginalName("SmsSenderService")] SmsSenderService = 7,
        /// <summary>
        /// WebHook
        /// </summary>
        [pbr::OriginalName("WebHook")] WebHook = 8,
        /// <summary>
        /// Chat Socket 连接
        /// </summary>
        [pbr::OriginalName("ChatSocket")] ChatSocket = 9,
        /// <summary>
        /// Chat 内部API
        /// </summary>
        [pbr::OriginalName("ChatApi")] ChatApi = 10,
        /// <summary>
        /// Chat HTTP
        /// </summary>
        [pbr::OriginalName("ChatHttp")] ChatHttp = 11,
        /// <summary>
        /// Chat 群聊头像服务
        /// </summary>
        [pbr::OriginalName("ChatAvatar")] ChatAvatar = 12,
        /// <summary>
        /// Chat 队列服务
        /// </summary>
        [pbr::OriginalName("ChatQueue")] ChatQueue = 13,
        /// <summary>
        /// 邮件连接器
        /// </summary>
        [pbr::OriginalName("MyMail")] MyMail = 14,
        /// <summary>
        /// 邮件连接器 扫描本地文件上传服务
        /// </summary>
        [pbr::OriginalName("MyMailUploader")] MyMailUploader = 15,
        /// <summary>
        /// 邮件连接器 静态附件承载服务
        /// </summary>
        [pbr::OriginalName("MyMailFileService")] MyMailFileService = 16,
        /// <summary>
        /// 运维工具
        /// </summary>
        [pbr::OriginalName("OpTool")] OpTool = 17,
        /// <summary>
        /// 三方账号联合登录服务
        /// </summary>
        [pbr::OriginalName("TpLogin")] TpLogin = 18,
        /// <summary>
        /// 短链生成服务
        /// </summary>
        [pbr::OriginalName("UrlParser")] UrlParser = 19,
        /// <summary>
        /// 微信公众号服务
        /// </summary>
        [pbr::OriginalName("WeixinMPService")] WeixinMpservice = 20,
        /// <summary>
        /// 明道大使
        /// </summary>
        [pbr::OriginalName("LP")] Lp = 21,
        /// <summary>
        /// OWA
        /// </summary>
        [pbr::OriginalName("OwaService")] OwaService = 22,
        /// <summary>
        /// 实体关联服务
        /// </summary>
        [pbr::OriginalName("RelationService")] RelationService = 23,
        /// <summary>
        ///计数服务(外网)
        /// </summary>
        [pbr::OriginalName("Counting")] Counting = 24,
        /// <summary>
        /// 计数服务(内网)
        /// </summary>
        [pbr::OriginalName("CountingInternal")] CountingInternal = 25,
        /// <summary>
        /// App Push 服务
        /// </summary>
        [pbr::OriginalName("PushQueue")] PushQueue = 26,
        /// <summary>
        /// Push Server API 服务
        /// </summary>
        [pbr::OriginalName("PushServer")] PushServer = 27,
        /// <summary>
        /// 会议室预定
        /// </summary>
        [pbr::OriginalName("Meetingroom")] Meetingroom = 28,
        /// <summary>
        /// 开放平台
        /// </summary>
        [pbr::OriginalName("Open")] Open = 29,
        /// <summary>
        /// Manage
        /// </summary>
        [pbr::OriginalName("MDManage")] Mdmanage = 30,
        /// <summary>
        /// 审批
        /// </summary>
        [pbr::OriginalName("Approval")] Approval = 31,
        /// <summary>
        /// OA
        /// </summary>
        [pbr::OriginalName("OA")] Oa = 32,
        /// <summary>
        /// Mingdao内部 CRM
        /// </summary>
        [pbr::OriginalName("MDCRM")] Mdcrm = 33,
        /// <summary>
        /// 考勤
        /// </summary>
        [pbr::OriginalName("Check")] Check = 34,
        /// <summary>
        /// 基础服务（已弃用）
        /// </summary>
        [pbr::OriginalName("BaseDataCacheService")] BaseDataCacheService = 35,
        /// <summary>
        /// 基础服务
        /// </summary>
        [pbr::OriginalName("BaseService")] BaseService = 36,
        /// <summary>
        /// 企业微信服务
        /// </summary>
        [pbr::OriginalName("WorkWeiXinService")] WorkWeiXinService = 37,
        /// <summary>
        /// 授权认证服务
        /// </summary>
        [pbr::OriginalName("AuthorizationService")] AuthorizationService = 38,
        /// <summary>
        /// 讨论服务
        /// </summary>
        [pbr::OriginalName("DiscussionService")] DiscussionService = 39,
        /// <summary>
        /// 角色服务
        /// </summary>
        [pbr::OriginalName("RoleService")] RoleService = 40,
        /// <summary>
        /// 组织结构服务
        /// </summary>
        [pbr::OriginalName("StructureService")] StructureService = 41,
        /// <summary>
        /// inbox消息服务
        /// </summary>
        [pbr::OriginalName("InboxService")] InboxService = 42,
        /// <summary>
        /// 工作表服务
        /// </summary>
        [pbr::OriginalName("WorkSheetService")] WorkSheetService = 43,
        /// <summary>
        /// ES搜索服务
        /// </summary>
        [pbr::OriginalName("ESService")] Esservice = 44,
        /// <summary>
        /// 群组服务
        /// </summary>
        [pbr::OriginalName("GroupService")] GroupService = 45,
        /// <summary>
        /// 附件服务
        /// </summary>
        [pbr::OriginalName("AttachmentService")] AttachmentService = 46,
        /// <summary>
        /// 控件服务
        /// </summary>
        [pbr::OriginalName("FormService")] FormService = 47,
    }

    /// <summary>
    /// 明道 developers
    /// </summary>
    public enum Developer
    {
        /// <summary>
        /// 未知
        /// </summary>
        [pbr::OriginalName("Undefined")] Undefined = 0,
        /// <summary>
        /// 朱颖骏（禁用）
        /// </summary>
        [pbr::OriginalName("RavenZhu")] RavenZhu = 1,
        /// <summary>
        /// 金可伟
        /// </summary>
        [pbr::OriginalName("JerryJin")] JerryJin = 2,
        /// <summary>
        /// 俞杭杰
        /// </summary>
        [pbr::OriginalName("EricYu")] EricYu = 3,
        /// <summary>
        /// 邹昕
        /// </summary>
        [pbr::OriginalName("SinZou")] SinZou = 4,
        /// <summary>
        /// 沈阳
        /// </summary>
        [pbr::OriginalName("WellsShen")] WellsShen = 5,
        /// <summary>
        /// 高喜庆
        /// </summary>
        [pbr::OriginalName("CarloseGao")] CarloseGao = 6,
        /// <summary>
        /// 吴群群
        /// </summary>
        [pbr::OriginalName("LeoWu")] LeoWu = 7,
        /// <summary>
        /// 杨广（禁用）
        /// </summary>
        [pbr::OriginalName("TobyYang")] TobyYang = 8,
        /// <summary>
        /// 朱斌
        /// </summary>
        [pbr::OriginalName("RennbonZhu")] RennbonZhu = 9,
        /// <summary>
        /// 金彪
        /// </summary>
        [pbr::OriginalName("BeckJin")] BeckJin = 10,
        /// <summary>
        /// 孙伟
        /// </summary>
        [pbr::OriginalName("AllenSun")] AllenSun = 11,
        /// <summary>
        /// 孙诚
        /// </summary>
        [pbr::OriginalName("Suncheng")] Suncheng = 12,
        /// <summary>
        /// 李合霖
        /// </summary>
        [pbr::OriginalName("Lihelin")] Lihelin = 13,
        /// <summary>
        /// 陆啸明
        /// </summary>
        [pbr::OriginalName("EdwardLu")] EdwardLu = 14,
        /// <summary>
        ///Chris(孙伟）
        /// </summary>
        [pbr::OriginalName("ChrisSun")] ChrisSun = 15,
    }

    #endregion

    #region Messages
    /// <summary>
    /// 输入
    /// </summary>
    public sealed partial class MingLog : pb::IMessage<MingLog>
    {
        private static readonly pb::MessageParser<MingLog> _parser = new pb::MessageParser<MingLog>(() => new MingLog());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<MingLog> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::MD.Logger.MinglogReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MingLog()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MingLog(MingLog other) : this()
        {
            timeStamp_ = other.timeStamp_;
            hostName_ = other.hostName_;
            serviceType_ = other.serviceType_;
            developer_ = other.developer_;
            clientIp_ = other.clientIp_;
            stack_ = other.stack_;
            message_ = other.message_;
            action_ = other.action_;
            accountId_ = other.accountId_;
            projectId_ = other.projectId_;
            level_ = other.level_;
            extras_ = other.extras_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public MingLog Clone()
        {
            return new MingLog(this);
        }

        /// <summary>Field number for the "timeStamp" field.</summary>
        public const int TimeStampFieldNumber = 1;
        private long timeStamp_;
        /// <summary>
        ///时间戳 (必填)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long TimeStamp
        {
            get { return timeStamp_; }
            set
            {
                timeStamp_ = value;
            }
        }

        /// <summary>Field number for the "hostName" field.</summary>
        public const int HostNameFieldNumber = 2;
        private string hostName_ = "";
        /// <summary>
        /// 服务器主机名(必填) cw_web,cw_meihua,cl_sandbox,e_node
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string HostName
        {
            get { return hostName_; }
            set
            {
                hostName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "serviceType" field.</summary>
        public const int ServiceTypeFieldNumber = 3;
        private global::MD.Logger.ServiceType serviceType_ = 0;
        /// <summary>
        /// 服务类型(必填) example : Master= 主站
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::MD.Logger.ServiceType ServiceType
        {
            get { return serviceType_; }
            set
            {
                serviceType_ = value;
            }
        }

        /// <summary>Field number for the "developer" field.</summary>
        public const int DeveloperFieldNumber = 4;
        private global::MD.Logger.Developer developer_ = 0;
        /// <summary>
        /// 日志记录者(必填) example: Raven
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::MD.Logger.Developer Developer
        {
            get { return developer_; }
            set
            {
                developer_ = value;
            }
        }

        /// <summary>Field number for the "clientIp" field.</summary>
        public const int ClientIpFieldNumber = 5;
        private string clientIp_ = "";
        /// <summary>
        /// 当前服务Ip
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ClientIp
        {
            get { return clientIp_; }
            set
            {
                clientIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "stack" field.</summary>
        public const int StackFieldNumber = 6;
        private string stack_ = "";
        /// <summary>
        /// 错误Stack信息
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Stack
        {
            get { return stack_; }
            set
            {
                stack_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "message" field.</summary>
        public const int MessageFieldNumber = 7;
        private string message_ = "";
        /// <summary>
        /// 日志文本信息
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Message
        {
            get { return message_; }
            set
            {
                message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "action" field.</summary>
        public const int ActionFieldNumber = 8;
        private string action_ = "";
        /// <summary>
        /// 当前记录操作类型, 当前代码的 "模块名:日志意图:其他"(必填)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Action
        {
            get { return action_; }
            set
            {
                action_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "accountId" field.</summary>
        public const int AccountIdFieldNumber = 9;
        private string accountId_ = "";
        /// <summary>
        /// 当前用户accountid
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string AccountId
        {
            get { return accountId_; }
            set
            {
                accountId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "projectId" field.</summary>
        public const int ProjectIdFieldNumber = 10;
        private string projectId_ = "";
        /// <summary>
        /// 当前用户projectid
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ProjectId
        {
            get { return projectId_; }
            set
            {
                projectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "level" field.</summary>
        public const int LevelFieldNumber = 11;
        private global::MD.Logger.LogLevel level_ = 0;
        /// <summary>
        /// 日志级别
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::MD.Logger.LogLevel Level
        {
            get { return level_; }
            set
            {
                level_ = value;
            }
        }

        /// <summary>Field number for the "extras" field.</summary>
        public const int ExtrasFieldNumber = 12;
        private static readonly pbc::MapField<string, string>.Codec _map_extras_codec
            = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 98);
        private readonly pbc::MapField<string, string> extras_ = new pbc::MapField<string, string>();
        /// <summary>
        /// 其他有用的信息字典
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, string> Extras
        {
            get { return extras_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as MingLog);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(MingLog other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (TimeStamp != other.TimeStamp) return false;
            if (HostName != other.HostName) return false;
            if (ServiceType != other.ServiceType) return false;
            if (Developer != other.Developer) return false;
            if (ClientIp != other.ClientIp) return false;
            if (Stack != other.Stack) return false;
            if (Message != other.Message) return false;
            if (Action != other.Action) return false;
            if (AccountId != other.AccountId) return false;
            if (ProjectId != other.ProjectId) return false;
            if (Level != other.Level) return false;
            if (!Extras.Equals(other.Extras)) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (TimeStamp != 0L) hash ^= TimeStamp.GetHashCode();
            if (HostName.Length != 0) hash ^= HostName.GetHashCode();
            if (ServiceType != 0) hash ^= ServiceType.GetHashCode();
            if (Developer != 0) hash ^= Developer.GetHashCode();
            if (ClientIp.Length != 0) hash ^= ClientIp.GetHashCode();
            if (Stack.Length != 0) hash ^= Stack.GetHashCode();
            if (Message.Length != 0) hash ^= Message.GetHashCode();
            if (Action.Length != 0) hash ^= Action.GetHashCode();
            if (AccountId.Length != 0) hash ^= AccountId.GetHashCode();
            if (ProjectId.Length != 0) hash ^= ProjectId.GetHashCode();
            if (Level != 0) hash ^= Level.GetHashCode();
            hash ^= Extras.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (TimeStamp != 0L)
            {
                output.WriteRawTag(8);
                output.WriteInt64(TimeStamp);
            }
            if (HostName.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(HostName);
            }
            if (ServiceType != 0)
            {
                output.WriteRawTag(24);
                output.WriteEnum((int)ServiceType);
            }
            if (Developer != 0)
            {
                output.WriteRawTag(32);
                output.WriteEnum((int)Developer);
            }
            if (ClientIp.Length != 0)
            {
                output.WriteRawTag(42);
                output.WriteString(ClientIp);
            }
            if (Stack.Length != 0)
            {
                output.WriteRawTag(50);
                output.WriteString(Stack);
            }
            if (Message.Length != 0)
            {
                output.WriteRawTag(58);
                output.WriteString(Message);
            }
            if (Action.Length != 0)
            {
                output.WriteRawTag(66);
                output.WriteString(Action);
            }
            if (AccountId.Length != 0)
            {
                output.WriteRawTag(74);
                output.WriteString(AccountId);
            }
            if (ProjectId.Length != 0)
            {
                output.WriteRawTag(82);
                output.WriteString(ProjectId);
            }
            if (Level != 0)
            {
                output.WriteRawTag(88);
                output.WriteEnum((int)Level);
            }
            extras_.WriteTo(output, _map_extras_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (TimeStamp != 0L)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeStamp);
            }
            if (HostName.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(HostName);
            }
            if (ServiceType != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ServiceType);
            }
            if (Developer != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Developer);
            }
            if (ClientIp.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientIp);
            }
            if (Stack.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Stack);
            }
            if (Message.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
            }
            if (Action.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Action);
            }
            if (AccountId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountId);
            }
            if (ProjectId.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(ProjectId);
            }
            if (Level != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Level);
            }
            size += extras_.CalculateSize(_map_extras_codec);
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(MingLog other)
        {
            if (other == null)
            {
                return;
            }
            if (other.TimeStamp != 0L)
            {
                TimeStamp = other.TimeStamp;
            }
            if (other.HostName.Length != 0)
            {
                HostName = other.HostName;
            }
            if (other.ServiceType != 0)
            {
                ServiceType = other.ServiceType;
            }
            if (other.Developer != 0)
            {
                Developer = other.Developer;
            }
            if (other.ClientIp.Length != 0)
            {
                ClientIp = other.ClientIp;
            }
            if (other.Stack.Length != 0)
            {
                Stack = other.Stack;
            }
            if (other.Message.Length != 0)
            {
                Message = other.Message;
            }
            if (other.Action.Length != 0)
            {
                Action = other.Action;
            }
            if (other.AccountId.Length != 0)
            {
                AccountId = other.AccountId;
            }
            if (other.ProjectId.Length != 0)
            {
                ProjectId = other.ProjectId;
            }
            if (other.Level != 0)
            {
                Level = other.Level;
            }
            extras_.Add(other.extras_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            TimeStamp = input.ReadInt64();
                            break;
                        }
                    case 18:
                        {
                            HostName = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            serviceType_ = (global::MD.Logger.ServiceType)input.ReadEnum();
                            break;
                        }
                    case 32:
                        {
                            developer_ = (global::MD.Logger.Developer)input.ReadEnum();
                            break;
                        }
                    case 42:
                        {
                            ClientIp = input.ReadString();
                            break;
                        }
                    case 50:
                        {
                            Stack = input.ReadString();
                            break;
                        }
                    case 58:
                        {
                            Message = input.ReadString();
                            break;
                        }
                    case 66:
                        {
                            Action = input.ReadString();
                            break;
                        }
                    case 74:
                        {
                            AccountId = input.ReadString();
                            break;
                        }
                    case 82:
                        {
                            ProjectId = input.ReadString();
                            break;
                        }
                    case 88:
                        {
                            level_ = (global::MD.Logger.LogLevel)input.ReadEnum();
                            break;
                        }
                    case 98:
                        {
                            extras_.AddEntriesFrom(input, _map_extras_codec);
                            break;
                        }
                }
            }
        }

    }

    /// <summary>
    /// 操作执行结果
    /// </summary>
    public sealed partial class ExecuteResult : pb::IMessage<ExecuteResult>
    {
        private static readonly pb::MessageParser<ExecuteResult> _parser = new pb::MessageParser<ExecuteResult>(() => new ExecuteResult());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ExecuteResult> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::MD.Logger.MinglogReflection.Descriptor.MessageTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExecuteResult()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExecuteResult(ExecuteResult other) : this()
        {
            isSuccess_ = other.isSuccess_;
            error_ = other.error_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ExecuteResult Clone()
        {
            return new ExecuteResult(this);
        }

        /// <summary>Field number for the "isSuccess" field.</summary>
        public const int IsSuccessFieldNumber = 1;
        private bool isSuccess_;
        /// <summary>
        /// 操作是否执行成功
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool IsSuccess
        {
            get { return isSuccess_; }
            set
            {
                isSuccess_ = value;
            }
        }

        /// <summary>Field number for the "error" field.</summary>
        public const int ErrorFieldNumber = 2;
        private string error_ = "";
        /// <summary>
        /// 错误信息
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Error
        {
            get { return error_; }
            set
            {
                error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as ExecuteResult);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ExecuteResult other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (IsSuccess != other.IsSuccess) return false;
            if (Error != other.Error) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
            if (Error.Length != 0) hash ^= Error.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (IsSuccess != false)
            {
                output.WriteRawTag(8);
                output.WriteBool(IsSuccess);
            }
            if (Error.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Error);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (IsSuccess != false)
            {
                size += 1 + 1;
            }
            if (Error.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ExecuteResult other)
        {
            if (other == null)
            {
                return;
            }
            if (other.IsSuccess != false)
            {
                IsSuccess = other.IsSuccess;
            }
            if (other.Error.Length != 0)
            {
                Error = other.Error;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 8:
                        {
                            IsSuccess = input.ReadBool();
                            break;
                        }
                    case 18:
                        {
                            Error = input.ReadString();
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code
