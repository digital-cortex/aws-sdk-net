/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationDiscoveryService.Model;

namespace Amazon.ApplicationDiscoveryService
{
    /// <summary>
    /// Interface for accessing ApplicationDiscoveryService
    ///
    /// AWS Application Discovery Service 
    /// <para>
    /// AWS Application Discovery Service helps you plan application migration projects by
    /// automatically identifying servers, virtual machines (VMs), software, and software
    /// dependencies running in your on-premises data centers. Application Discovery Service
    /// also collects application performance data, which can help you assess the outcome
    /// of your migration. The data collected by Application Discovery Service is securely
    /// retained in an Amazon-hosted and managed database in the cloud. You can export the
    /// data as a CSV or XML file into your preferred visualization tool or cloud-migration
    /// solution to plan your migration. For more information, see the Application Discovery
    /// Service <a href="http://aws.amazon.com/application-discovery/faqs/">FAQ</a>.
    /// </para>
    ///  
    /// <para>
    /// Application Discovery Service offers two modes of operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Agentless discovery</b> mode is recommended for environments that use VMware vCenter
    /// Server. This mode doesn't require you to install an agent on each host. Agentless
    /// discovery gathers server information regardless of the operating systems, which minimizes
    /// the time required for initial on-premises infrastructure assessment. Agentless discovery
    /// doesn't collect information about software and software dependencies. It also doesn't
    /// work in non-VMware environments. We recommend that you use agent-based discovery for
    /// non-VMware environments and if you want to collect information about software and
    /// software dependencies. You can also run agent-based and agentless discovery simultaneously.
    /// Use agentless discovery to quickly complete the initial infrastructure assessment
    /// and then install agents on select hosts to gather information about software and software
    /// dependencies.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Agent-based discovery</b> mode collects a richer set of data than agentless discovery
    /// by using Amazon software, the AWS Application Discovery Agent, which you install on
    /// one or more hosts in your data center. The agent captures infrastructure and application
    /// information, including an inventory of installed software applications, system and
    /// process performance, resource utilization, and network dependencies between workloads.
    /// The information collected by agents is secured at rest and in transit to the Application
    /// Discovery Service database in the cloud. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Discovery Service integrates with application discovery solutions from
    /// AWS Partner Network (APN) partners. Third-party application discovery tools can query
    /// Application Discovery Service and write to the Application Discovery Service database
    /// using a public API. You can then import the data into either a visualization tool
    /// or cloud-migration solution.
    /// </para>
    ///  <important> 
    /// <para>
    /// Application Discovery Service doesn't gather sensitive information. All data is handled
    /// according to the <a href="http://aws.amazon.com/privacy/">AWS Privacy Policy</a>.
    /// You can operate Application Discovery Service using offline mode to inspect collected
    /// data before it is shared with the service.
    /// </para>
    ///  </important> 
    /// <para>
    /// Your AWS account must be granted access to Application Discovery Service, a process
    /// called <i>whitelisting</i>. This is true for AWS partners and customers alike. To
    /// request access, sign up for AWS Application Discovery Service <a href="http://aws.amazon.com/application-discovery/preview/">here</a>.
    /// We send you information about how to get started.
    /// </para>
    ///  
    /// <para>
    /// This API reference provides descriptions, syntax, and usage examples for each of the
    /// actions and data types for Application Discovery Service. The topic for each action
    /// shows the API request parameters and the response. Alternatively, you can use one
    /// of the AWS SDKs to access an API that is tailored to the programming language or platform
    /// that you're using. For more information, see <a href="http://aws.amazon.com/tools/#SDKs">AWS
    /// SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// This guide is intended for use with the <a href="http://docs.aws.amazon.com/application-discovery/latest/userguide/">
    /// <i>AWS Application Discovery Service User Guide</i> </a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationDiscoveryService : IAmazonService, IDisposable
    {
                
        #region  AssociateConfigurationItemsToApplication


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConfigurationItemsToApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConfigurationItemsToApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AssociateConfigurationItemsToApplicationResponse> AssociateConfigurationItemsToApplicationAsync(AssociateConfigurationItemsToApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplication


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTags


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplications


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApplicationsResponse> DeleteApplicationsAsync(DeleteApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAgents


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAgentsResponse> DescribeAgentsAsync(DescribeAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeConfigurationsResponse> DescribeConfigurationsAsync(DescribeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExportConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("Deprecated in favor of DescribeExportTasks.")]
        Task<DescribeExportConfigurationsResponse> DescribeExportConfigurationsAsync(DescribeExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExportTasks


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateConfigurationItemsFromApplication


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConfigurationItemsFromApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConfigurationItemsFromApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisassociateConfigurationItemsFromApplicationResponse> DisassociateConfigurationItemsFromApplicationAsync(DisassociateConfigurationItemsFromApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the ExportConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        [Obsolete("Deprecated in favor of StartExportTask.")]
        Task<ExportConfigurationsResponse> ExportConfigurationsAsync(ExportConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDiscoverySummary


        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoverySummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoverySummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDiscoverySummaryResponse> GetDiscoverySummaryAsync(GetDiscoverySummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConfigurations


        /// <summary>
        /// Initiates the asynchronous execution of the ListConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListConfigurationsResponse> ListConfigurationsAsync(ListConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServerNeighbors


        /// <summary>
        /// Initiates the asynchronous execution of the ListServerNeighbors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerNeighbors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListServerNeighborsResponse> ListServerNeighborsAsync(ListServerNeighborsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDataCollectionByAgentIds


        /// <summary>
        /// Initiates the asynchronous execution of the StartDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartDataCollectionByAgentIdsResponse> StartDataCollectionByAgentIdsAsync(StartDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartExportTask


        /// <summary>
        /// Initiates the asynchronous execution of the StartExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartExportTaskResponse> StartExportTaskAsync(StartExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopDataCollectionByAgentIds


        /// <summary>
        /// Initiates the asynchronous execution of the StopDataCollectionByAgentIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataCollectionByAgentIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopDataCollectionByAgentIdsResponse> StopDataCollectionByAgentIdsAsync(StopDataCollectionByAgentIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}