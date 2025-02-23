﻿#if IOS || MACCATALYST
using PlatformView = AhiaPay.Platforms.MaciOS.MauiVideoPlayer;
#elif ANDROID
using PlatformView = AhiaPay.Platforms.Android.MauiVideoPlayer;
#elif WINDOWS
using PlatformView = AhiaPay.Platforms.Windows.MauiVideoPlayer;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

#if ANDROID || IOS || MACCATALYST || WINDOWS
using Microsoft.Maui.Handlers;

namespace AhiaPay.Handlers
{
    public partial class VideoHandler
    {
        public static IPropertyMapper<Video, VideoHandler> PropertyMapper = new PropertyMapper<Video, VideoHandler>(ViewHandler.ViewMapper)
        {
            [nameof(Video.AreTransportControlsEnabled)] = MapAreTransportControlsEnabled,
            [nameof(Video.Source)] = MapSource,
            [nameof(Video.IsLooping)] = MapIsLooping,
            [nameof(Video.Position)] = MapPosition
        };

        public static CommandMapper<Video, VideoHandler> CommandMapper = new(ViewCommandMapper)
        {
            [nameof(Video.UpdateStatus)] = MapUpdateStatus,
            [nameof(Video.PlayRequested)] = MapPlayRequested,
            [nameof(Video.PauseRequested)] = MapPauseRequested,
            [nameof(Video.StopRequested)] = MapStopRequested
        };

        public VideoHandler() : base(PropertyMapper, CommandMapper)
        {
        }
    }
}
#endif