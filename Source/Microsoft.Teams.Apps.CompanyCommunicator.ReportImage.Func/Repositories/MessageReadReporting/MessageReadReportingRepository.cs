﻿// <copyright file="SendingNotificationDataRepository.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories.NotificationData
{
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    /// <summary>
    /// Repository for the sending notification data in the table storage.
    /// </summary>
    public class MessageReadReportingRepository : BaseRepository<MessageReadReportingDataEntity>, IMessageReadReportingRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageReadReportingRepository"/> class.
        /// </summary>
        /// <param name="logger">The logging service.</param>
        /// <param name="repositoryOptions">Options used to create the repository.</param>
        public MessageReadReportingRepository(
            ILogger<SendingNotificationDataRepository> logger,
            IOptions<RepositoryOptions> repositoryOptions)
            : base(
                  logger,
                  storageAccountConnectionString: repositoryOptions.Value.StorageAccountConnectionString,
                  tableName: "MessageReadData",
                  defaultPartitionKey: "DefaultPartition",
                  ensureTableExists: repositoryOptions.Value.EnsureTableExists)
        {
        }
    }
}
