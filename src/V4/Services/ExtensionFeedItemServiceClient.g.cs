// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V4.Services
{
    /// <summary>Settings for <see cref="ExtensionFeedItemServiceClient"/> instances.</summary>
    public sealed partial class ExtensionFeedItemServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExtensionFeedItemServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExtensionFeedItemServiceSettings"/>.</returns>
        public static ExtensionFeedItemServiceSettings GetDefault() => new ExtensionFeedItemServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ExtensionFeedItemServiceSettings"/> object with default settings.
        /// </summary>
        public ExtensionFeedItemServiceSettings()
        {
        }

        private ExtensionFeedItemServiceSettings(ExtensionFeedItemServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetExtensionFeedItemSettings = existing.GetExtensionFeedItemSettings;
            MutateExtensionFeedItemsSettings = existing.MutateExtensionFeedItemsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExtensionFeedItemServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionFeedItemServiceClient.GetExtensionFeedItem</c> and
        /// <c>ExtensionFeedItemServiceClient.GetExtensionFeedItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExtensionFeedItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionFeedItemServiceClient.MutateExtensionFeedItems</c> and
        /// <c>ExtensionFeedItemServiceClient.MutateExtensionFeedItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateExtensionFeedItemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExtensionFeedItemServiceSettings"/> object.</returns>
        public ExtensionFeedItemServiceSettings Clone() => new ExtensionFeedItemServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExtensionFeedItemServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ExtensionFeedItemServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExtensionFeedItemServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExtensionFeedItemServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ExtensionFeedItemServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExtensionFeedItemServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExtensionFeedItemServiceClient Build()
        {
            ExtensionFeedItemServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExtensionFeedItemServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExtensionFeedItemServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExtensionFeedItemServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExtensionFeedItemServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ExtensionFeedItemServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExtensionFeedItemServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ExtensionFeedItemServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ExtensionFeedItemServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExtensionFeedItemServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ExtensionFeedItemService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage extension feed items.
    /// </remarks>
    public abstract partial class ExtensionFeedItemServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExtensionFeedItemService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ExtensionFeedItemService scopes.</summary>
        /// <remarks>
        /// The default ExtensionFeedItemService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ExtensionFeedItemServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ExtensionFeedItemServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        public static stt::Task<ExtensionFeedItemServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExtensionFeedItemServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExtensionFeedItemServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ExtensionFeedItemServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        public static ExtensionFeedItemServiceClient Create() => new ExtensionFeedItemServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExtensionFeedItemServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExtensionFeedItemServiceSettings"/>.</param>
        /// <returns>The created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        internal static ExtensionFeedItemServiceClient Create(grpccore::CallInvoker callInvoker, ExtensionFeedItemServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExtensionFeedItemService.ExtensionFeedItemServiceClient grpcClient = new ExtensionFeedItemService.ExtensionFeedItemServiceClient(callInvoker);
            return new ExtensionFeedItemServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ExtensionFeedItemService client</summary>
        public virtual ExtensionFeedItemService.ExtensionFeedItemServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ExtensionFeedItem GetExtensionFeedItem(GetExtensionFeedItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(GetExtensionFeedItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(GetExtensionFeedItemRequest request, st::CancellationToken cancellationToken) =>
            GetExtensionFeedItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ExtensionFeedItem GetExtensionFeedItem(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExtensionFeedItem(new GetExtensionFeedItemRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExtensionFeedItemAsync(new GetExtensionFeedItemRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetExtensionFeedItemAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ExtensionFeedItem GetExtensionFeedItem(gagvr::ExtensionFeedItemName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExtensionFeedItem(new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(gagvr::ExtensionFeedItemName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExtensionFeedItemAsync(new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(gagvr::ExtensionFeedItemName resourceName, st::CancellationToken cancellationToken) =>
            GetExtensionFeedItemAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateExtensionFeedItemsResponse MutateExtensionFeedItems(MutateExtensionFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(MutateExtensionFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(MutateExtensionFeedItemsRequest request, st::CancellationToken cancellationToken) =>
            MutateExtensionFeedItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual extension feed items.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateExtensionFeedItemsResponse MutateExtensionFeedItems(string customerId, scg::IEnumerable<ExtensionFeedItemOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateExtensionFeedItems(new MutateExtensionFeedItemsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual extension feed items.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(string customerId, scg::IEnumerable<ExtensionFeedItemOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateExtensionFeedItemsAsync(new MutateExtensionFeedItemsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual extension feed items.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(string customerId, scg::IEnumerable<ExtensionFeedItemOperation> operations, st::CancellationToken cancellationToken) =>
            MutateExtensionFeedItemsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ExtensionFeedItemService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage extension feed items.
    /// </remarks>
    public sealed partial class ExtensionFeedItemServiceClientImpl : ExtensionFeedItemServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetExtensionFeedItemRequest, gagvr::ExtensionFeedItem> _callGetExtensionFeedItem;

        private readonly gaxgrpc::ApiCall<MutateExtensionFeedItemsRequest, MutateExtensionFeedItemsResponse> _callMutateExtensionFeedItems;

        /// <summary>
        /// Constructs a client wrapper for the ExtensionFeedItemService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ExtensionFeedItemServiceSettings"/> used within this client.
        /// </param>
        public ExtensionFeedItemServiceClientImpl(ExtensionFeedItemService.ExtensionFeedItemServiceClient grpcClient, ExtensionFeedItemServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ExtensionFeedItemServiceSettings effectiveSettings = settings ?? ExtensionFeedItemServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetExtensionFeedItem = clientHelper.BuildApiCall<GetExtensionFeedItemRequest, gagvr::ExtensionFeedItem>(grpcClient.GetExtensionFeedItemAsync, grpcClient.GetExtensionFeedItem, effectiveSettings.GetExtensionFeedItemSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetExtensionFeedItem);
            Modify_GetExtensionFeedItemApiCall(ref _callGetExtensionFeedItem);
            _callMutateExtensionFeedItems = clientHelper.BuildApiCall<MutateExtensionFeedItemsRequest, MutateExtensionFeedItemsResponse>(grpcClient.MutateExtensionFeedItemsAsync, grpcClient.MutateExtensionFeedItems, effectiveSettings.MutateExtensionFeedItemsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateExtensionFeedItems);
            Modify_MutateExtensionFeedItemsApiCall(ref _callMutateExtensionFeedItems);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetExtensionFeedItemApiCall(ref gaxgrpc::ApiCall<GetExtensionFeedItemRequest, gagvr::ExtensionFeedItem> call);

        partial void Modify_MutateExtensionFeedItemsApiCall(ref gaxgrpc::ApiCall<MutateExtensionFeedItemsRequest, MutateExtensionFeedItemsResponse> call);

        partial void OnConstruction(ExtensionFeedItemService.ExtensionFeedItemServiceClient grpcClient, ExtensionFeedItemServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExtensionFeedItemService client</summary>
        public override ExtensionFeedItemService.ExtensionFeedItemServiceClient GrpcClient { get; }

        partial void Modify_GetExtensionFeedItemRequest(ref GetExtensionFeedItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateExtensionFeedItemsRequest(ref MutateExtensionFeedItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ExtensionFeedItem GetExtensionFeedItem(GetExtensionFeedItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExtensionFeedItemRequest(ref request, ref callSettings);
            return _callGetExtensionFeedItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(GetExtensionFeedItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExtensionFeedItemRequest(ref request, ref callSettings);
            return _callGetExtensionFeedItem.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateExtensionFeedItemsResponse MutateExtensionFeedItems(MutateExtensionFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExtensionFeedItemsRequest(ref request, ref callSettings);
            return _callMutateExtensionFeedItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(MutateExtensionFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExtensionFeedItemsRequest(ref request, ref callSettings);
            return _callMutateExtensionFeedItems.Async(request, callSettings);
        }
    }
}
