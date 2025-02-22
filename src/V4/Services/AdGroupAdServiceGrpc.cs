// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/ad_group_ad_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V4.Services {
  /// <summary>
  /// Service to manage ads in an ad group.
  /// </summary>
  public static partial class AdGroupAdService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.AdGroupAdService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest> __Marshaller_google_ads_googleads_v4_services_GetAdGroupAdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd> __Marshaller_google_ads_googleads_v4_resources_AdGroupAd = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest> __Marshaller_google_ads_googleads_v4_services_MutateAdGroupAdsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse> __Marshaller_google_ads_googleads_v4_services_MutateAdGroupAdsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest, global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd> __Method_GetAdGroupAd = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest, global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupAd",
        __Marshaller_google_ads_googleads_v4_services_GetAdGroupAdRequest,
        __Marshaller_google_ads_googleads_v4_resources_AdGroupAd);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse> __Method_MutateAdGroupAds = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupAds",
        __Marshaller_google_ads_googleads_v4_services_MutateAdGroupAdsRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateAdGroupAdsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.AdGroupAdServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupAdService</summary>
    [grpc::BindServiceMethod(typeof(AdGroupAdService), "BindService")]
    public abstract partial class AdGroupAdServiceBase
    {
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd> GetAdGroupAd(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes ads. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse> MutateAdGroupAds(global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupAdService</summary>
    public partial class AdGroupAdServiceClient : grpc::ClientBase<AdGroupAdServiceClient>
    {
      /// <summary>Creates a new client for AdGroupAdService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupAdServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupAdService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupAdServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupAdServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupAdServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd GetAdGroupAd(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupAd(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd GetAdGroupAd(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupAd, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd> GetAdGroupAdAsync(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupAdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd> GetAdGroupAdAsync(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupAd, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ads. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse MutateAdGroupAds(global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupAds(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ads. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse MutateAdGroupAds(global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupAds, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ads. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupAdsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ads. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupAds, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupAdServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupAdServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupAdServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupAd, serviceImpl.GetAdGroupAd)
          .AddMethod(__Method_MutateAdGroupAds, serviceImpl.MutateAdGroupAds).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupAdServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupAd, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdRequest, global::Google.Ads.GoogleAds.V4.Resources.AdGroupAd>(serviceImpl.GetAdGroupAd));
      serviceBinder.AddMethod(__Method_MutateAdGroupAds, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAdGroupAdsResponse>(serviceImpl.MutateAdGroupAds));
    }

  }
}
#endregion
