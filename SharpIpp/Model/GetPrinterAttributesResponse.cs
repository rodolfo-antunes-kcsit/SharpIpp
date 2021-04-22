﻿using System;
using System.Collections.Generic;

namespace SharpIpp.Model
{
    public class GetPrinterAttributesResponse
    {
        public IppVersion IppVersion { get; set; } = IppVersion.V11;
        public int RequestId { get; set; } = 1;

        /// <summary>
        ///     printer-uri-supported
        /// </summary>
        public string[] PrinterUriSupported { get; set; } = null!;

        /// <summary>
        ///     uri-security-supported
        /// </summary>
        public string[] UriSecuritySupported { get; set; } = null!;

        /// <summary>
        ///     uri-authentication-supported
        /// </summary>
        public string[] UriAuthenticationSupported { get; set; } = null!;

        /// <summary>
        ///     printer-name
        /// </summary>
        public string PrinterName { get; set; } = null!;

        /// <summary>
        ///     printer-location
        /// </summary>
        public string? PrinterLocation { get; set; }

        /// <summary>
        ///     printer-info
        /// </summary>
        public string? PrinterInfo { get; set; }

        /// <summary>
        ///     printer-more-info
        /// </summary>
        public string? PrinterMoreInfo { get; set; }

        /// <summary>
        ///     printer-driver-installer
        /// </summary>
        public string? PrinterDriverInstaller { get; set; }

        /// <summary>
        ///     printer-make-and-model
        /// </summary>
        public string? PrinterMakeAndModel { get; set; }

        /// <summary>
        ///     printer-more-info-manufacturer
        /// </summary>
        public string? PrinterMoreInfoManufacturer { get; set; }

        /// <summary>
        ///     printer-state
        /// </summary>
        public PrinterState PrinterState { get; set; }

        /// <summary>
        ///     printer-state-reasons
        /// </summary>
        public string[] PrinterStateReasons { get; set; } = null!;

        /// <summary>
        ///     printer-state-message
        /// </summary>
        public string? PrinterStateMessage { get; set; }

        /// <summary>
        ///     ipp-versions-supported
        /// </summary>
        public string[] IppVersionsSupported { get; set; } = null!;

        /// <summary>
        ///     operations-supported
        /// </summary>
        public IppOperation[] OperationsSupported { get; set; } = null!;

        /// <summary>
        ///     multiple-document-jobs-supported
        /// </summary>
        public bool? MultipleDocumentJobsSupported { get; set; }

        /// <summary>
        ///     charset-configured
        /// </summary>
        public string CharsetConfigured { get; set; } = null!;

        /// <summary>
        ///     charset-supported
        /// </summary>
        public string[] CharsetSupported { get; set; } = null!;

        /// <summary>
        ///     natural-language-configured
        /// </summary>
        public string NaturalLanguageConfigured { get; set; } = null!;

        /// <summary>
        ///     generated-natural-language-supported
        /// </summary>
        public string[] GeneratedNaturalLanguageSupported { get; set; } = null!;

        /// <summary>
        ///     document-format-default
        /// </summary>
        public string DocumentFormatDefault { get; set; } = null!;

        /// <summary>
        ///     document-format-supported
        /// </summary>
        public string[] DocumentFormatSupported { get; set; } = null!;

        /// <summary>
        ///     printer-is-accepting-jobs
        /// </summary>
        public bool PrinterIsAcceptingJobs { get; set; }

        /// <summary>
        ///     queued-job-count
        /// </summary>
        public int QueuedJobCount { get; set; }

        /// <summary>
        ///     printer-message-from-operator
        /// </summary>
        public string? PrinterMessageFromOperator { get; set; }

        /// <summary>
        ///     color-supported
        /// </summary>
        public bool? ColorSupported { get; set; }

        /// <summary>
        ///     reference-uri-schemes-supported
        /// </summary>
        public string[]? ReferenceUriSchemesSupported { get; set; }

        /// <summary>
        ///     pdl-override-supported
        /// </summary>
        public string PdlOverrideSupported { get; set; } = null!;

        /// <summary>
        ///     printer-up-time
        /// </summary>
        public int PrinterUpTime { get; set; }

        /// <summary>
        ///     printer-current-time
        /// </summary>
        public DateTimeOffset? PrinterCurrentTime { get; set; }

        /// <summary>
        ///     multiple-operation-time-out
        /// </summary>
        public int? MultipleOperationTimeOut { get; set; }

        /// <summary>
        ///     compression-supported
        /// </summary>
        public Compression[] CompressionSupported { get; set; } = null!;

        /// <summary>
        ///     job-k-octets-supported
        /// </summary>
        public Range? JobKOctetsSupported { get; set; }

        /// <summary>
        ///     job-impressions-supported
        /// </summary>
        public Range? JobImpressionsSupported { get; set; }

        /// <summary>
        ///     job-media-sheets-supported
        /// </summary>
        public Range? JobMediaSheetsSupported { get; set; }

        /// <summary>
        ///     pages-per-minute
        /// </summary>
        public int? PagesPerMinute { get; set; }

        /// <summary>
        ///     pages-per-minute-color
        /// </summary>
        public int? PagesPerMinuteColor { get; set; }

        public IDictionary<string, IppAttribute[]> AllAttributes { get; set; } = null!;
    }
}