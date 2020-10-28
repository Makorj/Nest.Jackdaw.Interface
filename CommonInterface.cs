using System;

namespace Jackdaw
{
    public static class InterfaceInfos
    {
        public static readonly string Version = "0.0.1-dev";
    }

    [Serializable]
    public struct RequestData
    {
        public RequestType commands;
        public string parameters;
    }

    [Serializable]
    public struct RequestCommand
    {
        public RequestType type;
        public TestType testType;
        public RequestPlatform platforms;
        public PublishPatform publishPatform;
    }

    [Flags]
    [Serializable]
    public enum RequestType : int
    {
        UpdateVCS = 1,
        RequestVCS = 2,

        Test = 4,
        Build = 8,
        Publish = 16,
    }

    [Flags]
    [Serializable]
    public enum TestType : short
    {
        Standalone = 1,
        Editor = 2,

        PlayTest = 4,
        EditTest = 8,
    }

    [Flags]
    [Serializable]
    public enum RequestPlatform : int
    {
        x32 = 1,
        x64 = 2,

        Windows = 4,
        Linux = 8,
        OSX = 16,
        Android = 32,
        IOS = 64,
        PS4 = 128,
        PS5 = 512,
        XBXONE = 1024,
        XBXSX = 2048,
        SWITCH = 4096,
        WebGL = 8192,
    }

    [Flags]
    [Serializable]
    public enum PublishPatform : int
    {
        Local = 1,
        Internal = 2,

        Steam = 4,
        Itch = 8,
        GOG = 16,
        UPlay = 32,
        Origin = 64,
    }
}
