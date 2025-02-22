// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/account_budget_proposal_service.proto
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
  /// A service for managing account-level budgets via proposals.
  ///
  /// A proposal is a request to create a new budget or make changes to an
  /// existing one.
  ///
  /// Reads for account-level budgets managed by these proposals will be
  /// supported in a future version. Until then, please use the
  /// BudgetOrderService from the AdWords API. Learn more at
  /// https://developers.google.com/adwords/api/docs/guides/budget-order
  ///
  /// Mutates:
  /// The CREATE operation creates a new proposal.
  /// UPDATE operations aren't supported.
  /// The REMOVE operation cancels a pending proposal.
  /// </summary>
  public static partial class AccountBudgetProposalService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.AccountBudgetProposalService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest> __Marshaller_google_ads_googleads_v4_services_GetAccountBudgetProposalRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal> __Marshaller_google_ads_googleads_v4_resources_AccountBudgetProposal = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest> __Marshaller_google_ads_googleads_v4_services_MutateAccountBudgetProposalRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse> __Marshaller_google_ads_googleads_v4_services_MutateAccountBudgetProposalResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest, global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal> __Method_GetAccountBudgetProposal = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest, global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountBudgetProposal",
        __Marshaller_google_ads_googleads_v4_services_GetAccountBudgetProposalRequest,
        __Marshaller_google_ads_googleads_v4_resources_AccountBudgetProposal);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse> __Method_MutateAccountBudgetProposal = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAccountBudgetProposal",
        __Marshaller_google_ads_googleads_v4_services_MutateAccountBudgetProposalRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateAccountBudgetProposalResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.AccountBudgetProposalServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AccountBudgetProposalService</summary>
    [grpc::BindServiceMethod(typeof(AccountBudgetProposalService), "BindService")]
    public abstract partial class AccountBudgetProposalServiceBase
    {
      /// <summary>
      /// Returns an account-level budget proposal in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal> GetAccountBudgetProposal(global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes account budget proposals.  Operation statuses
      /// are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse> MutateAccountBudgetProposal(global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AccountBudgetProposalService</summary>
    public partial class AccountBudgetProposalServiceClient : grpc::ClientBase<AccountBudgetProposalServiceClient>
    {
      /// <summary>Creates a new client for AccountBudgetProposalService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccountBudgetProposalServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccountBudgetProposalService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccountBudgetProposalServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccountBudgetProposalServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccountBudgetProposalServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns an account-level budget proposal in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal GetAccountBudgetProposal(global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountBudgetProposal(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns an account-level budget proposal in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal GetAccountBudgetProposal(global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAccountBudgetProposal, null, options, request);
      }
      /// <summary>
      /// Returns an account-level budget proposal in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal> GetAccountBudgetProposalAsync(global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAccountBudgetProposalAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns an account-level budget proposal in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal> GetAccountBudgetProposalAsync(global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAccountBudgetProposal, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes account budget proposals.  Operation statuses
      /// are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAccountBudgetProposal(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes account budget proposals.  Operation statuses
      /// are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAccountBudgetProposal, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes account budget proposals.  Operation statuses
      /// are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAccountBudgetProposalAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes account budget proposals.  Operation statuses
      /// are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAccountBudgetProposal, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccountBudgetProposalServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountBudgetProposalServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AccountBudgetProposalServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAccountBudgetProposal, serviceImpl.GetAccountBudgetProposal)
          .AddMethod(__Method_MutateAccountBudgetProposal, serviceImpl.MutateAccountBudgetProposal).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccountBudgetProposalServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAccountBudgetProposal, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetAccountBudgetProposalRequest, global::Google.Ads.GoogleAds.V4.Resources.AccountBudgetProposal>(serviceImpl.GetAccountBudgetProposal));
      serviceBinder.AddMethod(__Method_MutateAccountBudgetProposal, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAccountBudgetProposalResponse>(serviceImpl.MutateAccountBudgetProposal));
    }

  }
}
#endregion
