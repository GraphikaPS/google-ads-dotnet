// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/customer_negative_criterion_service.proto
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

namespace Google.Ads.GoogleAds.V5.Services {
  /// <summary>
  /// Service to manage customer negative criteria.
  /// </summary>
  public static partial class CustomerNegativeCriterionService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.CustomerNegativeCriterionService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest> __Marshaller_google_ads_googleads_v5_services_GetCustomerNegativeCriterionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion> __Marshaller_google_ads_googleads_v5_resources_CustomerNegativeCriterion = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest> __Marshaller_google_ads_googleads_v5_services_MutateCustomerNegativeCriteriaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse> __Marshaller_google_ads_googleads_v5_services_MutateCustomerNegativeCriteriaResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion> __Method_GetCustomerNegativeCriterion = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerNegativeCriterion",
        __Marshaller_google_ads_googleads_v5_services_GetCustomerNegativeCriterionRequest,
        __Marshaller_google_ads_googleads_v5_resources_CustomerNegativeCriterion);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse> __Method_MutateCustomerNegativeCriteria = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomerNegativeCriteria",
        __Marshaller_google_ads_googleads_v5_services_MutateCustomerNegativeCriteriaRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateCustomerNegativeCriteriaResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.CustomerNegativeCriterionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerNegativeCriterionService</summary>
    [grpc::BindServiceMethod(typeof(CustomerNegativeCriterionService), "BindService")]
    public abstract partial class CustomerNegativeCriterionServiceBase
    {
      /// <summary>
      /// Returns the requested criterion in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion> GetCustomerNegativeCriterion(global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteria(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerNegativeCriterionService</summary>
    public partial class CustomerNegativeCriterionServiceClient : grpc::ClientBase<CustomerNegativeCriterionServiceClient>
    {
      /// <summary>Creates a new client for CustomerNegativeCriterionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerNegativeCriterionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerNegativeCriterionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerNegativeCriterionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerNegativeCriterionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerNegativeCriterionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion GetCustomerNegativeCriterion(global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerNegativeCriterion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion GetCustomerNegativeCriterion(global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerNegativeCriterion, null, options, request);
      }
      /// <summary>
      /// Returns the requested criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerNegativeCriterionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested criterion in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerNegativeCriterion, null, options, request);
      }
      /// <summary>
      /// Creates or removes criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerNegativeCriteria(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomerNegativeCriteria, null, options, request);
      }
      /// <summary>
      /// Creates or removes criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerNegativeCriteriaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes criteria. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomerNegativeCriteria, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerNegativeCriterionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerNegativeCriterionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerNegativeCriterionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerNegativeCriterion, serviceImpl.GetCustomerNegativeCriterion)
          .AddMethod(__Method_MutateCustomerNegativeCriteria, serviceImpl.MutateCustomerNegativeCriteria).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerNegativeCriterionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerNegativeCriterion, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetCustomerNegativeCriterionRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerNegativeCriterion>(serviceImpl.GetCustomerNegativeCriterion));
      serviceBinder.AddMethod(__Method_MutateCustomerNegativeCriteria, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerNegativeCriteriaResponse>(serviceImpl.MutateCustomerNegativeCriteria));
    }

  }
}
#endregion
