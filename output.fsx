namespace Microsoft.Storage.StorageAccounts

module ``2015-05-01-preview`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name. Name is the CNAME source.
            ``name`` : string option
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates
            ``useSubDomainName`` : bool option
        }
        static member create(?``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// Gets or sets the account type.
            ``accountType`` : obj // AccountType option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue or table object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is StandardGRS or StandardRAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo replicated secondary for the storage account. Only available if the accountType is StandardGRS or StandardRAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the accountType is StandardGRS or StandardRAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The URIs that are used to perform a retrieval of a public blob, queue or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``accountType``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``customDomain``, ?``secondaryEndpoints``) =
            {
                ``accountType`` = ``accountType``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``customDomain`` = ``customDomain``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource location
            ``location`` : string
            /// Resource tags
            ``tags`` : Map<string, string> option
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``location``, ?``id``, ?``tags``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``properties`` = ``properties``
            }
module ``2015-06-15`` =
    type Endpoints =
        {
            /// The blob endpoint.
            ``blob`` : string option
            /// The queue endpoint.
            ``queue`` : string option
            /// The table endpoint.
            ``table`` : string option
            /// The file endpoint.
            ``file`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
            }
    type CustomDomain =
        {
            /// The custom domain name. Name is the CNAME source.
            ``name`` : string option
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates
            ``useSubDomainName`` : bool option
        }
        static member create(?``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``accountType`` : obj // AccountType
            /// The status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue or table object.
            ``primaryEndpoints`` : Endpoints option
            /// The location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// The status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// The timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// The location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// The status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// The creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The URIs that are used to perform a retrieval of a public blob, queue or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(``accountType``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``customDomain``, ?``secondaryEndpoints``) =
            {
                ``accountType`` = ``accountType``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``customDomain`` = ``customDomain``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// A list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``location``, ?``id``, ?``tags``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``properties`` = ``properties``
            }
module ``2016-01-01`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
        }
        static member create(?``blob``) =
            {
                ``blob`` = ``blob``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage
            ``keySource`` : string
        }
        static member create(``keySource``, ?``services``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``accessTier``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``accessTier`` = ``accessTier``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``properties`` = ``properties``
            }
module ``2016-05-01`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
        }
        static member create(?``blob``) =
            {
                ``blob`` = ``blob``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage
            ``keySource`` : string
        }
        static member create(``keySource``, ?``services``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``accessTier``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``accessTier`` = ``accessTier``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``properties`` = ``properties``
            }
module ``2016-12-01`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage
            ``keySource`` : string
        }
        static member create(``keySource``, ?``services``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``accessTier``, ?``supportsHttpsTrafficOnly``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``accessTier`` = ``accessTier``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``properties`` = ``properties``
            }
module ``2017-06-01`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``supportsHttpsTrafficOnly``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2017-10-01`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, or table object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``supportsHttpsTrafficOnly``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2018-02-01`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2018-03-01-preview`` =
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the sku name. Required for account creation; optional for update. Note that in older versions, sku name was called accountType.
            ``name`` : obj // Name
            /// Gets the sku tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified sku, including file encryption, network acls, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2018-07-01`` =
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Enables Azure Files AAD Integration for SMB if sets to true.
            ``azureFilesAadIntegration`` : bool option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesAadIntegration``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesAadIntegration`` = ``azureFilesAadIntegration``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType.
            ``name`` : obj // Name
            /// Gets the SKU tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2018-11-01`` =
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Enables Azure Files AAD Integration for SMB if sets to true.
            ``azureFilesAadIntegration`` : bool option
            /// Allows https traffic only to storage service if sets to true.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesAadIntegration``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesAadIntegration`` = ``azureFilesAadIntegration``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType.
            ``name`` : obj // Name
            /// Gets the SKU tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2019-04-01`` =
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type ActiveDirectoryProperties =
        {
            /// Specifies the primary domain that the AD DNS server is authoritative for.
            ``domainName`` : string
            /// Specifies the NetBIOS domain name.
            ``netBiosDomainName`` : string
            /// Specifies the Active Directory forest to get.
            ``forestName`` : string
            /// Specifies the domain GUID.
            ``domainGuid`` : string
            /// Specifies the security identifier (SID).
            ``domainSid`` : string
            /// Specifies the security identifier (SID) for Azure Storage.
            ``azureStorageSid`` : string
        }
        static member create(``domainName``, ``netBiosDomainName``, ``forestName``, ``domainGuid``, ``domainSid``, ``azureStorageSid``) =
            {
                ``domainName`` = ``domainName``
                ``netBiosDomainName`` = ``netBiosDomainName``
                ``forestName`` = ``forestName``
                ``domainGuid`` = ``domainGuid``
                ``domainSid`` = ``domainSid``
                ``azureStorageSid`` = ``azureStorageSid``
            }
    type AzureFilesIdentityBasedAuthentication =
        {
            /// Indicates the directory service used.
            ``directoryServiceOptions`` : obj // DirectoryServiceOptions
            /// Settings properties for Active Directory (AD).
            ``activeDirectoryProperties`` : ActiveDirectoryProperties option
        }
        static member create(``directoryServiceOptions``, ?``activeDirectoryProperties``) =
            {
                ``directoryServiceOptions`` = ``directoryServiceOptions``
                ``activeDirectoryProperties`` = ``activeDirectoryProperties``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
        }
        static member create(?``enabled``, ?``lastEnabledTime``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Settings for Azure Files identity based authentication.
            ``azureFilesIdentityBasedAuthentication`` : AzureFilesIdentityBasedAuthentication option
            /// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
            ``largeFileSharesState`` : obj // LargeFileSharesState option
            /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
            ``allowBlobPublicAccess`` : bool option
            /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
            ``minimumTlsVersion`` : obj // MinimumTlsVersion option
            /// Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true.
            ``allowSharedKeyAccess`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesIdentityBasedAuthentication``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``largeFileSharesState``, ?``allowBlobPublicAccess``, ?``minimumTlsVersion``, ?``allowSharedKeyAccess``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesIdentityBasedAuthentication`` = ``azureFilesIdentityBasedAuthentication``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``largeFileSharesState`` = ``largeFileSharesState``
                ``allowBlobPublicAccess`` = ``allowBlobPublicAccess``
                ``minimumTlsVersion`` = ``minimumTlsVersion``
                ``allowSharedKeyAccess`` = ``allowSharedKeyAccess``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Restriction =
        {
            /// The type of restrictions. As of now only possible value for this is location.
            ``type`` : string option
            /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.
            ``values`` : string array option
            /// The reason for the restriction. As of now this can be "QuotaId" or "NotAvailableForSubscription". Quota Id is set when the SKU has requiredQuotas parameter as the subscription does not belong to that quota. The "NotAvailableForSubscription" is related to capacity at DC.
            ``reasonCode`` : obj // ReasonCode option
        }
        static member create(?``type``, ?``values``, ?``reasonCode``) =
            {
                ``type`` = ``type``
                ``values`` = ``values``
                ``reasonCode`` = ``reasonCode``
            }
    type SKUCapability =
        {
            /// The name of capability, The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc.
            ``name`` : string option
            /// A string value to indicate states of given capability. Possibly 'true' or 'false'.
            ``value`` : string option
        }
        static member create(?``name``, ?``value``) =
            {
                ``name`` = ``name``
                ``value`` = ``value``
            }
    type Sku =
        {
            /// Gets or sets the SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType.
            ``name`` : obj // Name
            /// Gets the SKU tier. This is based on the SKU name.
            ``tier`` : obj // Tier option
            /// The type of the resource, usually it is 'storageAccounts'.
            ``resourceType`` : string option
            /// Indicates the type of storage account.
            ``kind`` : obj // Kind option
            /// The set of locations that the SKU is available. This will be supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.).
            ``locations`` : string array option
            /// The capability information in the specified SKU, including file encryption, network ACLs, change notification, etc.
            ``capabilities`` : SKUCapability array option
            /// The restrictions because of which SKU cannot be used. This is empty if there are no restrictions.
            ``restrictions`` : Restriction array option
        }
        static member create(``name``, ?``tier``, ?``resourceType``, ?``kind``, ?``locations``, ?``capabilities``, ?``restrictions``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
                ``resourceType`` = ``resourceType``
                ``kind`` = ``kind``
                ``locations`` = ``locations``
                ``capabilities`` = ``capabilities``
                ``restrictions`` = ``restrictions``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type BlobRestoreRange =
        {
            /// Blob start range. This is inclusive. Empty means account start.
            ``startRange`` : string option
            /// Blob end range. This is exclusive. Empty means account end.
            ``endRange`` : string option
        }
        static member create(?``startRange``, ?``endRange``) =
            {
                ``startRange`` = ``startRange``
                ``endRange`` = ``endRange``
            }
    type BlobRestoreParameters =
        {
            /// Restore blob to the specified time.
            ``timeToRestore`` : string option
            /// Blob ranges to restore.
            ``blobRanges`` : BlobRestoreRange array option
        }
        static member create(?``timeToRestore``, ?``blobRanges``) =
            {
                ``timeToRestore`` = ``timeToRestore``
                ``blobRanges`` = ``blobRanges``
            }
    type BlobRestoreStatus =
        {
            /// The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed.
            ``status`` : obj // Status option
            /// Failure reason when blob restore is failed.
            ``failureReason`` : string option
            /// Id for tracking blob restore request.
            ``restoreId`` : string option
            /// Blob restore parameters
            ``parameters`` : BlobRestoreParameters option
        }
        static member create(?``status``, ?``failureReason``, ?``restoreId``, ?``parameters``) =
            {
                ``status`` = ``status``
                ``failureReason`` = ``failureReason``
                ``restoreId`` = ``restoreId``
                ``parameters`` = ``parameters``
            }
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
            ``id`` : string option
            /// The name of the resource
            ``name`` : string option
            /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
            ``type`` : string option
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(?``id``, ?``name``, ?``type``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``type`` = ``type``
                ``properties`` = ``properties``
            }
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type StorageAccountInternetEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type StorageAccountMicrosoftEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing endpoint.
            ``microsoftEndpoints`` : StorageAccountMicrosoftEndpoints option
            /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
            ``internetEndpoints`` : StorageAccountInternetEndpoints option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``, ?``microsoftEndpoints``, ?``internetEndpoints``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
                ``microsoftEndpoints`` = ``microsoftEndpoints``
                ``internetEndpoints`` = ``internetEndpoints``
            }
    type RoutingPreference =
        {
            /// Routing Choice defines the kind of network routing opted by the user.
            ``routingChoice`` : obj // RoutingChoice option
            /// A boolean flag which indicates whether microsoft routing storage endpoints are to be published
            ``publishMicrosoftEndpoints`` : bool option
            /// A boolean flag which indicates whether internet routing storage endpoints are to be published
            ``publishInternetEndpoints`` : bool option
        }
        static member create(?``routingChoice``, ?``publishMicrosoftEndpoints``, ?``publishInternetEndpoints``) =
            {
                ``routingChoice`` = ``routingChoice``
                ``publishMicrosoftEndpoints`` = ``publishMicrosoftEndpoints``
                ``publishInternetEndpoints`` = ``publishInternetEndpoints``
            }
    type ActiveDirectoryProperties =
        {
            /// Specifies the primary domain that the AD DNS server is authoritative for.
            ``domainName`` : string
            /// Specifies the NetBIOS domain name.
            ``netBiosDomainName`` : string
            /// Specifies the Active Directory forest to get.
            ``forestName`` : string
            /// Specifies the domain GUID.
            ``domainGuid`` : string
            /// Specifies the security identifier (SID).
            ``domainSid`` : string
            /// Specifies the security identifier (SID) for Azure Storage.
            ``azureStorageSid`` : string
        }
        static member create(``domainName``, ``netBiosDomainName``, ``forestName``, ``domainGuid``, ``domainSid``, ``azureStorageSid``) =
            {
                ``domainName`` = ``domainName``
                ``netBiosDomainName`` = ``netBiosDomainName``
                ``forestName`` = ``forestName``
                ``domainGuid`` = ``domainGuid``
                ``domainSid`` = ``domainSid``
                ``azureStorageSid`` = ``azureStorageSid``
            }
    type AzureFilesIdentityBasedAuthentication =
        {
            /// Indicates the directory service used.
            ``directoryServiceOptions`` : obj // DirectoryServiceOptions
            /// Settings properties for Active Directory (AD).
            ``activeDirectoryProperties`` : ActiveDirectoryProperties option
        }
        static member create(``directoryServiceOptions``, ?``activeDirectoryProperties``) =
            {
                ``directoryServiceOptions`` = ``directoryServiceOptions``
                ``activeDirectoryProperties`` = ``activeDirectoryProperties``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
            /// The object identifier of the current versioned Key Vault Key in use.
            ``currentVersionedKeyIdentifier`` : string option
            /// Timestamp of last rotation of the Key Vault Key.
            ``lastKeyRotationTimestamp`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``, ?``currentVersionedKeyIdentifier``, ?``lastKeyRotationTimestamp``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
                ``currentVersionedKeyIdentifier`` = ``currentVersionedKeyIdentifier``
                ``lastKeyRotationTimestamp`` = ``lastKeyRotationTimestamp``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
            /// Encryption key type to be used for the encryption service. 'Account' key type implies that an account-scoped encryption key will be used. 'Service' key type implies that a default service key is used.
            ``keyType`` : obj // KeyType option
        }
        static member create(?``enabled``, ?``lastEnabledTime``, ?``keyType``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``keyType`` = ``keyType``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
            ``requireInfrastructureEncryption`` : bool option
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``requireInfrastructureEncryption``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``requireInfrastructureEncryption`` = ``requireInfrastructureEncryption``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Settings for Azure Files identity based authentication.
            ``azureFilesIdentityBasedAuthentication`` : AzureFilesIdentityBasedAuthentication option
            /// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
            ``largeFileSharesState`` : obj // LargeFileSharesState option
            /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user data, the default option is microsoft routing
            ``routingPreference`` : RoutingPreference option
            /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
            ``allowBlobPublicAccess`` : bool option
            /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
            ``minimumTlsVersion`` : obj // MinimumTlsVersion option
            /// Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true.
            ``allowSharedKeyAccess`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
            /// List of private endpoint connection associated with the specified storage account
            ``privateEndpointConnections`` : PrivateEndpointConnection array option
            /// Blob restore status.
            ``blobRestoreStatus`` : BlobRestoreStatus option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesIdentityBasedAuthentication``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``largeFileSharesState``, ?``routingPreference``, ?``allowBlobPublicAccess``, ?``minimumTlsVersion``, ?``allowSharedKeyAccess``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``, ?``privateEndpointConnections``, ?``blobRestoreStatus``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesIdentityBasedAuthentication`` = ``azureFilesIdentityBasedAuthentication``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``largeFileSharesState`` = ``largeFileSharesState``
                ``routingPreference`` = ``routingPreference``
                ``allowBlobPublicAccess`` = ``allowBlobPublicAccess``
                ``minimumTlsVersion`` = ``minimumTlsVersion``
                ``allowSharedKeyAccess`` = ``allowSharedKeyAccess``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
                ``privateEndpointConnections`` = ``privateEndpointConnections``
                ``blobRestoreStatus`` = ``blobRestoreStatus``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type BlobRestoreRange =
        {
            /// Blob start range. This is inclusive. Empty means account start.
            ``startRange`` : string option
            /// Blob end range. This is exclusive. Empty means account end.
            ``endRange`` : string option
        }
        static member create(?``startRange``, ?``endRange``) =
            {
                ``startRange`` = ``startRange``
                ``endRange`` = ``endRange``
            }
    type BlobRestoreParameters =
        {
            /// Restore blob to the specified time.
            ``timeToRestore`` : string option
            /// Blob ranges to restore.
            ``blobRanges`` : BlobRestoreRange array option
        }
        static member create(?``timeToRestore``, ?``blobRanges``) =
            {
                ``timeToRestore`` = ``timeToRestore``
                ``blobRanges`` = ``blobRanges``
            }
    type BlobRestoreStatus =
        {
            /// The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed.
            ``status`` : obj // Status option
            /// Failure reason when blob restore is failed.
            ``failureReason`` : string option
            /// Id for tracking blob restore request.
            ``restoreId`` : string option
            /// Blob restore parameters
            ``parameters`` : BlobRestoreParameters option
        }
        static member create(?``status``, ?``failureReason``, ?``restoreId``, ?``parameters``) =
            {
                ``status`` = ``status``
                ``failureReason`` = ``failureReason``
                ``restoreId`` = ``restoreId``
                ``parameters`` = ``parameters``
            }
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
            ``id`` : string option
            /// The name of the resource
            ``name`` : string option
            /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
            ``type`` : string option
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(?``id``, ?``name``, ?``type``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``type`` = ``type``
                ``properties`` = ``properties``
            }
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type StorageAccountInternetEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type StorageAccountMicrosoftEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing endpoint.
            ``microsoftEndpoints`` : StorageAccountMicrosoftEndpoints option
            /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
            ``internetEndpoints`` : StorageAccountInternetEndpoints option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``, ?``microsoftEndpoints``, ?``internetEndpoints``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
                ``microsoftEndpoints`` = ``microsoftEndpoints``
                ``internetEndpoints`` = ``internetEndpoints``
            }
    type RoutingPreference =
        {
            /// Routing Choice defines the kind of network routing opted by the user.
            ``routingChoice`` : obj // RoutingChoice option
            /// A boolean flag which indicates whether microsoft routing storage endpoints are to be published
            ``publishMicrosoftEndpoints`` : bool option
            /// A boolean flag which indicates whether internet routing storage endpoints are to be published
            ``publishInternetEndpoints`` : bool option
        }
        static member create(?``routingChoice``, ?``publishMicrosoftEndpoints``, ?``publishInternetEndpoints``) =
            {
                ``routingChoice`` = ``routingChoice``
                ``publishMicrosoftEndpoints`` = ``publishMicrosoftEndpoints``
                ``publishInternetEndpoints`` = ``publishInternetEndpoints``
            }
    type ActiveDirectoryProperties =
        {
            /// Specifies the primary domain that the AD DNS server is authoritative for.
            ``domainName`` : string
            /// Specifies the NetBIOS domain name.
            ``netBiosDomainName`` : string
            /// Specifies the Active Directory forest to get.
            ``forestName`` : string
            /// Specifies the domain GUID.
            ``domainGuid`` : string
            /// Specifies the security identifier (SID).
            ``domainSid`` : string
            /// Specifies the security identifier (SID) for Azure Storage.
            ``azureStorageSid`` : string
        }
        static member create(``domainName``, ``netBiosDomainName``, ``forestName``, ``domainGuid``, ``domainSid``, ``azureStorageSid``) =
            {
                ``domainName`` = ``domainName``
                ``netBiosDomainName`` = ``netBiosDomainName``
                ``forestName`` = ``forestName``
                ``domainGuid`` = ``domainGuid``
                ``domainSid`` = ``domainSid``
                ``azureStorageSid`` = ``azureStorageSid``
            }
    type AzureFilesIdentityBasedAuthentication =
        {
            /// Indicates the directory service used.
            ``directoryServiceOptions`` : obj // DirectoryServiceOptions
            /// Settings properties for Active Directory (AD).
            ``activeDirectoryProperties`` : ActiveDirectoryProperties option
        }
        static member create(``directoryServiceOptions``, ?``activeDirectoryProperties``) =
            {
                ``directoryServiceOptions`` = ``directoryServiceOptions``
                ``activeDirectoryProperties`` = ``activeDirectoryProperties``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type ResourceAccessRule =
        {
            /// Tenant Id
            ``tenantId`` : string option
            /// Resource Id
            ``resourceId`` : string option
        }
        static member create(?``tenantId``, ?``resourceId``) =
            {
                ``tenantId`` = ``tenantId``
                ``resourceId`` = ``resourceId``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            ``resourceAccessRules`` : ResourceAccessRule array option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``resourceAccessRules``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``resourceAccessRules`` = ``resourceAccessRules``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
            /// The object identifier of the current versioned Key Vault Key in use.
            ``currentVersionedKeyIdentifier`` : string option
            /// Timestamp of last rotation of the Key Vault Key.
            ``lastKeyRotationTimestamp`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``, ?``currentVersionedKeyIdentifier``, ?``lastKeyRotationTimestamp``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
                ``currentVersionedKeyIdentifier`` = ``currentVersionedKeyIdentifier``
                ``lastKeyRotationTimestamp`` = ``lastKeyRotationTimestamp``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
            /// Encryption key type to be used for the encryption service. 'Account' key type implies that an account-scoped encryption key will be used. 'Service' key type implies that a default service key is used.
            ``keyType`` : obj // KeyType option
        }
        static member create(?``enabled``, ?``lastEnabledTime``, ?``keyType``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``keyType`` = ``keyType``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
            ``requireInfrastructureEncryption`` : bool option
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
        }
        static member create(``keySource``, ?``services``, ?``requireInfrastructureEncryption``, ?``keyvaultproperties``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``requireInfrastructureEncryption`` = ``requireInfrastructureEncryption``
                ``keyvaultproperties`` = ``keyvaultproperties``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Settings for Azure Files identity based authentication.
            ``azureFilesIdentityBasedAuthentication`` : AzureFilesIdentityBasedAuthentication option
            /// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
            ``largeFileSharesState`` : obj // LargeFileSharesState option
            /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user data, the default option is microsoft routing
            ``routingPreference`` : RoutingPreference option
            /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
            ``allowBlobPublicAccess`` : bool option
            /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
            ``minimumTlsVersion`` : obj // MinimumTlsVersion option
            /// Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true.
            ``allowSharedKeyAccess`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
            /// List of private endpoint connection associated with the specified storage account
            ``privateEndpointConnections`` : PrivateEndpointConnection array option
            /// Blob restore status.
            ``blobRestoreStatus`` : BlobRestoreStatus option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesIdentityBasedAuthentication``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``largeFileSharesState``, ?``routingPreference``, ?``allowBlobPublicAccess``, ?``minimumTlsVersion``, ?``allowSharedKeyAccess``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``, ?``privateEndpointConnections``, ?``blobRestoreStatus``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesIdentityBasedAuthentication`` = ``azureFilesIdentityBasedAuthentication``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``largeFileSharesState`` = ``largeFileSharesState``
                ``routingPreference`` = ``routingPreference``
                ``allowBlobPublicAccess`` = ``allowBlobPublicAccess``
                ``minimumTlsVersion`` = ``minimumTlsVersion``
                ``allowSharedKeyAccess`` = ``allowSharedKeyAccess``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
                ``privateEndpointConnections`` = ``privateEndpointConnections``
                ``blobRestoreStatus`` = ``blobRestoreStatus``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : string
        }
        static member create(``type``, ?``principalId``, ?``tenantId``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
            }
    type ExtendedLocation =
        {
            /// The name of the extended location.
            ``name`` : string option
        }
        static member create(?``name``) =
            {
                ``name`` = ``name``
            }
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// The complex type of the extended location.
            ``extendedLocation`` : ExtendedLocation option
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``extendedLocation``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``extendedLocation`` = ``extendedLocation``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type BlobRestoreRange =
        {
            /// Blob start range. This is inclusive. Empty means account start.
            ``startRange`` : string option
            /// Blob end range. This is exclusive. Empty means account end.
            ``endRange`` : string option
        }
        static member create(?``startRange``, ?``endRange``) =
            {
                ``startRange`` = ``startRange``
                ``endRange`` = ``endRange``
            }
    type BlobRestoreParameters =
        {
            /// Restore blob to the specified time.
            ``timeToRestore`` : string option
            /// Blob ranges to restore.
            ``blobRanges`` : BlobRestoreRange array option
        }
        static member create(?``timeToRestore``, ?``blobRanges``) =
            {
                ``timeToRestore`` = ``timeToRestore``
                ``blobRanges`` = ``blobRanges``
            }
    type BlobRestoreStatus =
        {
            /// The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed.
            ``status`` : obj // Status option
            /// Failure reason when blob restore is failed.
            ``failureReason`` : string option
            /// Id for tracking blob restore request.
            ``restoreId`` : string option
            /// Blob restore parameters
            ``parameters`` : BlobRestoreParameters option
        }
        static member create(?``status``, ?``failureReason``, ?``restoreId``, ?``parameters``) =
            {
                ``status`` = ``status``
                ``failureReason`` = ``failureReason``
                ``restoreId`` = ``restoreId``
                ``parameters`` = ``parameters``
            }
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
            ``id`` : string option
            /// The name of the resource
            ``name`` : string option
            /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
            ``type`` : string option
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(?``id``, ?``name``, ?``type``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``type`` = ``type``
                ``properties`` = ``properties``
            }
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type StorageAccountInternetEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type StorageAccountMicrosoftEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing endpoint.
            ``microsoftEndpoints`` : StorageAccountMicrosoftEndpoints option
            /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
            ``internetEndpoints`` : StorageAccountInternetEndpoints option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``, ?``microsoftEndpoints``, ?``internetEndpoints``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
                ``microsoftEndpoints`` = ``microsoftEndpoints``
                ``internetEndpoints`` = ``internetEndpoints``
            }
    type RoutingPreference =
        {
            /// Routing Choice defines the kind of network routing opted by the user.
            ``routingChoice`` : obj // RoutingChoice option
            /// A boolean flag which indicates whether microsoft routing storage endpoints are to be published
            ``publishMicrosoftEndpoints`` : bool option
            /// A boolean flag which indicates whether internet routing storage endpoints are to be published
            ``publishInternetEndpoints`` : bool option
        }
        static member create(?``routingChoice``, ?``publishMicrosoftEndpoints``, ?``publishInternetEndpoints``) =
            {
                ``routingChoice`` = ``routingChoice``
                ``publishMicrosoftEndpoints`` = ``publishMicrosoftEndpoints``
                ``publishInternetEndpoints`` = ``publishInternetEndpoints``
            }
    type ActiveDirectoryProperties =
        {
            /// Specifies the primary domain that the AD DNS server is authoritative for.
            ``domainName`` : string
            /// Specifies the NetBIOS domain name.
            ``netBiosDomainName`` : string
            /// Specifies the Active Directory forest to get.
            ``forestName`` : string
            /// Specifies the domain GUID.
            ``domainGuid`` : string
            /// Specifies the security identifier (SID).
            ``domainSid`` : string
            /// Specifies the security identifier (SID) for Azure Storage.
            ``azureStorageSid`` : string
        }
        static member create(``domainName``, ``netBiosDomainName``, ``forestName``, ``domainGuid``, ``domainSid``, ``azureStorageSid``) =
            {
                ``domainName`` = ``domainName``
                ``netBiosDomainName`` = ``netBiosDomainName``
                ``forestName`` = ``forestName``
                ``domainGuid`` = ``domainGuid``
                ``domainSid`` = ``domainSid``
                ``azureStorageSid`` = ``azureStorageSid``
            }
    type AzureFilesIdentityBasedAuthentication =
        {
            /// Indicates the directory service used.
            ``directoryServiceOptions`` : obj // DirectoryServiceOptions
            /// Settings properties for Active Directory (AD).
            ``activeDirectoryProperties`` : ActiveDirectoryProperties option
        }
        static member create(``directoryServiceOptions``, ?``activeDirectoryProperties``) =
            {
                ``directoryServiceOptions`` = ``directoryServiceOptions``
                ``activeDirectoryProperties`` = ``activeDirectoryProperties``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type ResourceAccessRule =
        {
            /// Tenant Id
            ``tenantId`` : string option
            /// Resource Id
            ``resourceId`` : string option
        }
        static member create(?``tenantId``, ?``resourceId``) =
            {
                ``tenantId`` = ``tenantId``
                ``resourceId`` = ``resourceId``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the resource access rules
            ``resourceAccessRules`` : ResourceAccessRule array option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``resourceAccessRules``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``resourceAccessRules`` = ``resourceAccessRules``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type EncryptionIdentity =
        {
            /// Resource identifier of the UserAssigned identity to be associated with server-side encryption on the storage account.
            ``userAssignedIdentity`` : string option
        }
        static member create(?``userAssignedIdentity``) =
            {
                ``userAssignedIdentity`` = ``userAssignedIdentity``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
            /// The object identifier of the current versioned Key Vault Key in use.
            ``currentVersionedKeyIdentifier`` : string option
            /// Timestamp of last rotation of the Key Vault Key.
            ``lastKeyRotationTimestamp`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``, ?``currentVersionedKeyIdentifier``, ?``lastKeyRotationTimestamp``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
                ``currentVersionedKeyIdentifier`` = ``currentVersionedKeyIdentifier``
                ``lastKeyRotationTimestamp`` = ``lastKeyRotationTimestamp``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
            /// Encryption key type to be used for the encryption service. 'Account' key type implies that an account-scoped encryption key will be used. 'Service' key type implies that a default service key is used.
            ``keyType`` : obj // KeyType option
        }
        static member create(?``enabled``, ?``lastEnabledTime``, ?``keyType``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``keyType`` = ``keyType``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
            ``requireInfrastructureEncryption`` : bool option
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
            /// Encryption identity for the storage account.
            ``identity`` : EncryptionIdentity option
        }
        static member create(``keySource``, ?``services``, ?``requireInfrastructureEncryption``, ?``keyvaultproperties``, ?``identity``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``requireInfrastructureEncryption`` = ``requireInfrastructureEncryption``
                ``keyvaultproperties`` = ``keyvaultproperties``
                ``identity`` = ``identity``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Settings for Azure Files identity based authentication.
            ``azureFilesIdentityBasedAuthentication`` : AzureFilesIdentityBasedAuthentication option
            /// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
            ``largeFileSharesState`` : obj // LargeFileSharesState option
            /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user data, the default option is microsoft routing
            ``routingPreference`` : RoutingPreference option
            /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
            ``allowBlobPublicAccess`` : bool option
            /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
            ``minimumTlsVersion`` : obj // MinimumTlsVersion option
            /// Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true.
            ``allowSharedKeyAccess`` : bool option
            /// NFS 3.0 protocol support enabled if set to true.
            ``isNfsV3Enabled`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
            /// List of private endpoint connection associated with the specified storage account
            ``privateEndpointConnections`` : PrivateEndpointConnection array option
            /// Blob restore status.
            ``blobRestoreStatus`` : BlobRestoreStatus option
        }
        static member create(?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesIdentityBasedAuthentication``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``largeFileSharesState``, ?``routingPreference``, ?``allowBlobPublicAccess``, ?``minimumTlsVersion``, ?``allowSharedKeyAccess``, ?``isNfsV3Enabled``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``, ?``privateEndpointConnections``, ?``blobRestoreStatus``) =
            {
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesIdentityBasedAuthentication`` = ``azureFilesIdentityBasedAuthentication``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``largeFileSharesState`` = ``largeFileSharesState``
                ``routingPreference`` = ``routingPreference``
                ``allowBlobPublicAccess`` = ``allowBlobPublicAccess``
                ``minimumTlsVersion`` = ``minimumTlsVersion``
                ``allowSharedKeyAccess`` = ``allowSharedKeyAccess``
                ``isNfsV3Enabled`` = ``isNfsV3Enabled``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
                ``privateEndpointConnections`` = ``privateEndpointConnections``
                ``blobRestoreStatus`` = ``blobRestoreStatus``
            }
    type UserAssignedIdentity =
        {
            /// The principal ID of the identity.
            ``principalId`` : string option
            /// The client ID of the identity.
            ``clientId`` : string option
        }
        static member create(?``principalId``, ?``clientId``) =
            {
                ``principalId`` = ``principalId``
                ``clientId`` = ``clientId``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : obj // Type
            /// Gets or sets a list of key value pairs that describe the set of User Assigned identities that will be used with this storage account. The key is the ARM resource identifier of the identity. Only 1 User Assigned identity is permitted here.
            ``userAssignedIdentities`` : Map<string, UserAssignedIdentity> option
        }
        static member create(``type``, ?``principalId``, ?``tenantId``, ?``userAssignedIdentities``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
                ``userAssignedIdentities`` = ``userAssignedIdentities``
            }
    type ExtendedLocation =
        {
            /// The name of the extended location.
            ``name`` : string option
        }
        static member create(?``name``) =
            {
                ``name`` = ``name``
            }
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// The complex type of the extended location.
            ``extendedLocation`` : ExtendedLocation option
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``extendedLocation``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``extendedLocation`` = ``extendedLocation``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type BlobRestoreRange =
        {
            /// Blob start range. This is inclusive. Empty means account start.
            ``startRange`` : string option
            /// Blob end range. This is exclusive. Empty means account end.
            ``endRange`` : string option
        }
        static member create(?``startRange``, ?``endRange``) =
            {
                ``startRange`` = ``startRange``
                ``endRange`` = ``endRange``
            }
    type BlobRestoreParameters =
        {
            /// Restore blob to the specified time.
            ``timeToRestore`` : string option
            /// Blob ranges to restore.
            ``blobRanges`` : BlobRestoreRange array option
        }
        static member create(?``timeToRestore``, ?``blobRanges``) =
            {
                ``timeToRestore`` = ``timeToRestore``
                ``blobRanges`` = ``blobRanges``
            }
    type BlobRestoreStatus =
        {
            /// The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing. - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed.
            ``status`` : obj // Status option
            /// Failure reason when blob restore is failed.
            ``failureReason`` : string option
            /// Id for tracking blob restore request.
            ``restoreId`` : string option
            /// Blob restore parameters
            ``parameters`` : BlobRestoreParameters option
        }
        static member create(?``status``, ?``failureReason``, ?``restoreId``, ?``parameters``) =
            {
                ``status`` = ``status``
                ``failureReason`` = ``failureReason``
                ``restoreId`` = ``restoreId``
                ``parameters`` = ``parameters``
            }
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
            ``id`` : string option
            /// The name of the resource
            ``name`` : string option
            /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
            ``type`` : string option
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(?``id``, ?``name``, ?``type``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``type`` = ``type``
                ``properties`` = ``properties``
            }
    type GeoReplicationStats =
        {
            /// The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the secondary location is temporarily unavailable.
            ``status`` : obj // Status option
            /// All primary writes preceding this UTC date/time value are guaranteed to be available for read operations. Primary writes following this point in time may or may not be available for reads. Element may be default value if value of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
            ``lastSyncTime`` : string option
            /// A boolean flag which indicates whether or not account failover is supported for the account.
            ``canFailover`` : bool option
        }
        static member create(?``status``, ?``lastSyncTime``, ?``canFailover``) =
            {
                ``status`` = ``status``
                ``lastSyncTime`` = ``lastSyncTime``
                ``canFailover`` = ``canFailover``
            }
    type StorageAccountInternetEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type StorageAccountMicrosoftEndpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
            }
    type Endpoints =
        {
            /// Gets the blob endpoint.
            ``blob`` : string option
            /// Gets the queue endpoint.
            ``queue`` : string option
            /// Gets the table endpoint.
            ``table`` : string option
            /// Gets the file endpoint.
            ``file`` : string option
            /// Gets the web endpoint.
            ``web`` : string option
            /// Gets the dfs endpoint.
            ``dfs`` : string option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing endpoint.
            ``microsoftEndpoints`` : StorageAccountMicrosoftEndpoints option
            /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
            ``internetEndpoints`` : StorageAccountInternetEndpoints option
        }
        static member create(?``blob``, ?``queue``, ?``table``, ?``file``, ?``web``, ?``dfs``, ?``microsoftEndpoints``, ?``internetEndpoints``) =
            {
                ``blob`` = ``blob``
                ``queue`` = ``queue``
                ``table`` = ``table``
                ``file`` = ``file``
                ``web`` = ``web``
                ``dfs`` = ``dfs``
                ``microsoftEndpoints`` = ``microsoftEndpoints``
                ``internetEndpoints`` = ``internetEndpoints``
            }
    type KeyCreationTime =
        {
            ``key1`` : string option
            ``key2`` : string option
        }
        static member create(?``key1``, ?``key2``) =
            {
                ``key1`` = ``key1``
                ``key2`` = ``key2``
            }
    type RoutingPreference =
        {
            /// Routing Choice defines the kind of network routing opted by the user.
            ``routingChoice`` : obj // RoutingChoice option
            /// A boolean flag which indicates whether microsoft routing storage endpoints are to be published
            ``publishMicrosoftEndpoints`` : bool option
            /// A boolean flag which indicates whether internet routing storage endpoints are to be published
            ``publishInternetEndpoints`` : bool option
        }
        static member create(?``routingChoice``, ?``publishMicrosoftEndpoints``, ?``publishInternetEndpoints``) =
            {
                ``routingChoice`` = ``routingChoice``
                ``publishMicrosoftEndpoints`` = ``publishMicrosoftEndpoints``
                ``publishInternetEndpoints`` = ``publishInternetEndpoints``
            }
    type ActiveDirectoryProperties =
        {
            /// Specifies the primary domain that the AD DNS server is authoritative for.
            ``domainName`` : string
            /// Specifies the NetBIOS domain name.
            ``netBiosDomainName`` : string
            /// Specifies the Active Directory forest to get.
            ``forestName`` : string
            /// Specifies the domain GUID.
            ``domainGuid`` : string
            /// Specifies the security identifier (SID).
            ``domainSid`` : string
            /// Specifies the security identifier (SID) for Azure Storage.
            ``azureStorageSid`` : string
        }
        static member create(``domainName``, ``netBiosDomainName``, ``forestName``, ``domainGuid``, ``domainSid``, ``azureStorageSid``) =
            {
                ``domainName`` = ``domainName``
                ``netBiosDomainName`` = ``netBiosDomainName``
                ``forestName`` = ``forestName``
                ``domainGuid`` = ``domainGuid``
                ``domainSid`` = ``domainSid``
                ``azureStorageSid`` = ``azureStorageSid``
            }
    type AzureFilesIdentityBasedAuthentication =
        {
            /// Indicates the directory service used.
            ``directoryServiceOptions`` : obj // DirectoryServiceOptions
            /// Settings properties for Active Directory (AD).
            ``activeDirectoryProperties`` : ActiveDirectoryProperties option
        }
        static member create(``directoryServiceOptions``, ?``activeDirectoryProperties``) =
            {
                ``directoryServiceOptions`` = ``directoryServiceOptions``
                ``activeDirectoryProperties`` = ``activeDirectoryProperties``
            }
    type IPRule =
        {
            /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
            ``value`` : string
        }
        static member create(``value``) =
            {
                ``value`` = ``value``
            }
    type VirtualNetworkRule =
        {
            /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
            ``id`` : string
            /// Gets the state of virtual network rule.
            ``state`` : obj // State option
        }
        static member create(``id``, ?``state``) =
            {
                ``id`` = ``id``
                ``state`` = ``state``
            }
    type ResourceAccessRule =
        {
            /// Tenant Id
            ``tenantId`` : string option
            /// Resource Id
            ``resourceId`` : string option
        }
        static member create(?``tenantId``, ?``resourceId``) =
            {
                ``tenantId`` = ``tenantId``
                ``resourceId`` = ``resourceId``
            }
    type NetworkRuleSet =
        {
            /// Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of Logging|Metrics|AzureServices (For example, "Logging, Metrics"), or None to bypass none of those traffics.
            ``bypass`` : obj // Bypass option
            /// Sets the resource access rules
            ``resourceAccessRules`` : ResourceAccessRule array option
            /// Sets the virtual network rules
            ``virtualNetworkRules`` : VirtualNetworkRule array option
            /// Sets the IP ACL rules
            ``ipRules`` : IPRule array option
            /// Specifies the default action of allow or deny when no other rules match.
            ``defaultAction`` : obj // DefaultAction
        }
        static member create(``defaultAction``, ?``bypass``, ?``resourceAccessRules``, ?``virtualNetworkRules``, ?``ipRules``) =
            {
                ``bypass`` = ``bypass``
                ``resourceAccessRules`` = ``resourceAccessRules``
                ``virtualNetworkRules`` = ``virtualNetworkRules``
                ``ipRules`` = ``ipRules``
                ``defaultAction`` = ``defaultAction``
            }
    type EncryptionIdentity =
        {
            /// Resource identifier of the UserAssigned identity to be associated with server-side encryption on the storage account.
            ``userAssignedIdentity`` : string option
        }
        static member create(?``userAssignedIdentity``) =
            {
                ``userAssignedIdentity`` = ``userAssignedIdentity``
            }
    type KeyVaultProperties =
        {
            /// The name of KeyVault key.
            ``keyname`` : string option
            /// The version of KeyVault key.
            ``keyversion`` : string option
            /// The Uri of KeyVault.
            ``keyvaulturi`` : string option
            /// The object identifier of the current versioned Key Vault Key in use.
            ``currentVersionedKeyIdentifier`` : string option
            /// Timestamp of last rotation of the Key Vault Key.
            ``lastKeyRotationTimestamp`` : string option
        }
        static member create(?``keyname``, ?``keyversion``, ?``keyvaulturi``, ?``currentVersionedKeyIdentifier``, ?``lastKeyRotationTimestamp``) =
            {
                ``keyname`` = ``keyname``
                ``keyversion`` = ``keyversion``
                ``keyvaulturi`` = ``keyvaulturi``
                ``currentVersionedKeyIdentifier`` = ``currentVersionedKeyIdentifier``
                ``lastKeyRotationTimestamp`` = ``lastKeyRotationTimestamp``
            }
    type EncryptionService =
        {
            /// A boolean indicating whether or not the service encrypts the data as it is stored.
            ``enabled`` : bool option
            /// Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a rough estimate.
            ``lastEnabledTime`` : string option
            /// Encryption key type to be used for the encryption service. 'Account' key type implies that an account-scoped encryption key will be used. 'Service' key type implies that a default service key is used.
            ``keyType`` : obj // KeyType option
        }
        static member create(?``enabled``, ?``lastEnabledTime``, ?``keyType``) =
            {
                ``enabled`` = ``enabled``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``keyType`` = ``keyType``
            }
    type EncryptionServices =
        {
            /// A service that allows server-side encryption to be used.
            ``blob`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``file`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``table`` : EncryptionService option
            /// A service that allows server-side encryption to be used.
            ``queue`` : EncryptionService option
        }
        static member create(?``blob``, ?``file``, ?``table``, ?``queue``) =
            {
                ``blob`` = ``blob``
                ``file`` = ``file``
                ``table`` = ``table``
                ``queue`` = ``queue``
            }
    type Encryption =
        {
            /// A list of services that support encryption.
            ``services`` : EncryptionServices option
            /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault.
            ``keySource`` : obj // KeySource
            /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
            ``requireInfrastructureEncryption`` : bool option
            /// Properties of key vault.
            ``keyvaultproperties`` : KeyVaultProperties option
            /// Encryption identity for the storage account.
            ``identity`` : EncryptionIdentity option
        }
        static member create(``keySource``, ?``services``, ?``requireInfrastructureEncryption``, ?``keyvaultproperties``, ?``identity``) =
            {
                ``services`` = ``services``
                ``keySource`` = ``keySource``
                ``requireInfrastructureEncryption`` = ``requireInfrastructureEncryption``
                ``keyvaultproperties`` = ``keyvaultproperties``
                ``identity`` = ``identity``
            }
    type CustomDomain =
        {
            /// Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.
            ``name`` : string
            /// Indicates whether indirect CName validation is enabled. Default value is false. This should only be set on updates.
            ``useSubDomainName`` : bool option
        }
        static member create(``name``, ?``useSubDomainName``) =
            {
                ``name`` = ``name``
                ``useSubDomainName`` = ``useSubDomainName``
            }
    type KeyPolicy =
        {
            /// The key expiration period in days.
            ``keyExpirationPeriodInDays`` : int
        }
        static member create(``keyExpirationPeriodInDays``) =
            {
                ``keyExpirationPeriodInDays`` = ``keyExpirationPeriodInDays``
            }
    type SasPolicy =
        {
            /// The SAS expiration period, DD.HH:MM:SS.
            ``sasExpirationPeriod`` : string
            /// The SAS expiration action. Can only be Log.
            ``expirationAction`` : string
        }
        static member create(``sasExpirationPeriod``, ``expirationAction``) =
            {
                ``sasExpirationPeriod`` = ``sasExpirationPeriod``
                ``expirationAction`` = ``expirationAction``
            }
    type StorageAccountPropertiesCreateParameters =
        {
            /// SasPolicy assigned to the storage account.
            ``sasPolicy`` : SasPolicy option
            /// KeyPolicy assigned to the storage account.
            ``keyPolicy`` : KeyPolicy option
            /// The custom domain assigned to this storage account. This can be set via Update.
            ``customDomain`` : CustomDomain option
            /// The encryption settings on the storage account.
            ``encryption`` : Encryption option
            /// Network rule set
            ``networkAcls`` : NetworkRuleSet option
            /// Required for storage accounts where kind = BlobStorage. The access tier used for billing.
            ``accessTier`` : obj // AccessTier option
            /// Settings for Azure Files identity based authentication.
            ``azureFilesIdentityBasedAuthentication`` : AzureFilesIdentityBasedAuthentication option
            /// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
            ``supportsHttpsTrafficOnly`` : bool option
            /// Account HierarchicalNamespace enabled if sets to true.
            ``isHnsEnabled`` : bool option
            /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
            ``largeFileSharesState`` : obj // LargeFileSharesState option
            /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user data, the default option is microsoft routing
            ``routingPreference`` : RoutingPreference option
            /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
            ``allowBlobPublicAccess`` : bool option
            /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
            ``minimumTlsVersion`` : obj // MinimumTlsVersion option
            /// Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true.
            ``allowSharedKeyAccess`` : bool option
            /// NFS 3.0 protocol support enabled if set to true.
            ``isNfsV3Enabled`` : bool option
            /// Gets the status of the storage account at the time the operation was called.
            ``provisioningState`` : obj // ProvisioningState option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``primaryEndpoints`` : Endpoints option
            /// Gets the location of the primary data center for the storage account.
            ``primaryLocation`` : string option
            /// Gets the status indicating whether the primary location of the storage account is available or unavailable.
            ``statusOfPrimary`` : obj // StatusOfPrimary option
            /// Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``lastGeoFailoverTime`` : string option
            /// Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
            ``secondaryLocation`` : string option
            /// Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
            ``statusOfSecondary`` : obj // StatusOfSecondary option
            /// Gets the creation date and time of the storage account in UTC.
            ``creationTime`` : string option
            /// Storage account keys creation time.
            ``keyCreationTime`` : KeyCreationTime option
            /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
            ``secondaryEndpoints`` : Endpoints option
            /// Statistics related to replication for storage account's Blob, Table, Queue and File services. It is only available when geo-redundant replication is enabled for the storage account.
            ``geoReplicationStats`` : GeoReplicationStats option
            /// If the failover is in progress, the value will be true, otherwise, it will be null.
            ``failoverInProgress`` : bool option
            /// List of private endpoint connection associated with the specified storage account
            ``privateEndpointConnections`` : PrivateEndpointConnection array option
            /// Blob restore status.
            ``blobRestoreStatus`` : BlobRestoreStatus option
        }
        static member create(?``sasPolicy``, ?``keyPolicy``, ?``customDomain``, ?``encryption``, ?``networkAcls``, ?``accessTier``, ?``azureFilesIdentityBasedAuthentication``, ?``supportsHttpsTrafficOnly``, ?``isHnsEnabled``, ?``largeFileSharesState``, ?``routingPreference``, ?``allowBlobPublicAccess``, ?``minimumTlsVersion``, ?``allowSharedKeyAccess``, ?``isNfsV3Enabled``, ?``provisioningState``, ?``primaryEndpoints``, ?``primaryLocation``, ?``statusOfPrimary``, ?``lastGeoFailoverTime``, ?``secondaryLocation``, ?``statusOfSecondary``, ?``creationTime``, ?``keyCreationTime``, ?``secondaryEndpoints``, ?``geoReplicationStats``, ?``failoverInProgress``, ?``privateEndpointConnections``, ?``blobRestoreStatus``) =
            {
                ``sasPolicy`` = ``sasPolicy``
                ``keyPolicy`` = ``keyPolicy``
                ``customDomain`` = ``customDomain``
                ``encryption`` = ``encryption``
                ``networkAcls`` = ``networkAcls``
                ``accessTier`` = ``accessTier``
                ``azureFilesIdentityBasedAuthentication`` = ``azureFilesIdentityBasedAuthentication``
                ``supportsHttpsTrafficOnly`` = ``supportsHttpsTrafficOnly``
                ``isHnsEnabled`` = ``isHnsEnabled``
                ``largeFileSharesState`` = ``largeFileSharesState``
                ``routingPreference`` = ``routingPreference``
                ``allowBlobPublicAccess`` = ``allowBlobPublicAccess``
                ``minimumTlsVersion`` = ``minimumTlsVersion``
                ``allowSharedKeyAccess`` = ``allowSharedKeyAccess``
                ``isNfsV3Enabled`` = ``isNfsV3Enabled``
                ``provisioningState`` = ``provisioningState``
                ``primaryEndpoints`` = ``primaryEndpoints``
                ``primaryLocation`` = ``primaryLocation``
                ``statusOfPrimary`` = ``statusOfPrimary``
                ``lastGeoFailoverTime`` = ``lastGeoFailoverTime``
                ``secondaryLocation`` = ``secondaryLocation``
                ``statusOfSecondary`` = ``statusOfSecondary``
                ``creationTime`` = ``creationTime``
                ``keyCreationTime`` = ``keyCreationTime``
                ``secondaryEndpoints`` = ``secondaryEndpoints``
                ``geoReplicationStats`` = ``geoReplicationStats``
                ``failoverInProgress`` = ``failoverInProgress``
                ``privateEndpointConnections`` = ``privateEndpointConnections``
                ``blobRestoreStatus`` = ``blobRestoreStatus``
            }
    type UserAssignedIdentity =
        {
            /// The principal ID of the identity.
            ``principalId`` : string option
            /// The client ID of the identity.
            ``clientId`` : string option
        }
        static member create(?``principalId``, ?``clientId``) =
            {
                ``principalId`` = ``principalId``
                ``clientId`` = ``clientId``
            }
    type Identity =
        {
            /// The principal ID of resource identity.
            ``principalId`` : string option
            /// The tenant ID of resource.
            ``tenantId`` : string option
            /// The identity type.
            ``type`` : obj // Type
            /// Gets or sets a list of key value pairs that describe the set of User Assigned identities that will be used with this storage account. The key is the ARM resource identifier of the identity. Only 1 User Assigned identity is permitted here.
            ``userAssignedIdentities`` : Map<string, UserAssignedIdentity> option
        }
        static member create(``type``, ?``principalId``, ?``tenantId``, ?``userAssignedIdentities``) =
            {
                ``principalId`` = ``principalId``
                ``tenantId`` = ``tenantId``
                ``type`` = ``type``
                ``userAssignedIdentities`` = ``userAssignedIdentities``
            }
    type ExtendedLocation =
        {
            /// The name of the extended location.
            ``name`` : string option
        }
        static member create(?``name``) =
            {
                ``name`` = ``name``
            }
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type StorageAccount =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The SKU of the storage account.
            ``sku`` : Sku
            /// Required. Indicates the type of storage account.
            ``kind`` : obj // Kind
            /// Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is created, but if an identical geo region is specified on update, the request will succeed.
            ``location`` : string
            /// The complex type of the extended location.
            ``extendedLocation`` : ExtendedLocation option
            /// Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key with a length no greater than 128 characters and a value with a length no greater than 256 characters.
            ``tags`` : Map<string, string> option
            /// Identity for the resource.
            ``identity`` : Identity option
            /// The parameters used to create the storage account.
            ``properties`` : StorageAccountPropertiesCreateParameters option
        }
        static member create(``name``, ``sku``, ``kind``, ``location``, ?``id``, ?``extendedLocation``, ?``tags``, ?``identity``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``sku`` = ``sku``
                ``kind`` = ``kind``
                ``location`` = ``location``
                ``extendedLocation`` = ``extendedLocation``
                ``tags`` = ``tags``
                ``identity`` = ``identity``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.BlobServices

module ``2018-07-01`` =
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The blob service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2018-11-01`` =
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The blob service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2019-04-01`` =
    type ChangeFeed =
        {
            /// Indicates whether change feed event logging is enabled for the Blob service.
            ``enabled`` : bool option
        }
        static member create(?``enabled``) =
            {
                ``enabled`` = ``enabled``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted blob should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The blob service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Automatic Snapshot is enabled if set to true.
            ``automaticSnapshotPolicyEnabled`` : bool option
            /// The blob service properties for change feed events.
            ``changeFeed`` : ChangeFeed option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``, ?``automaticSnapshotPolicyEnabled``, ?``changeFeed``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
                ``automaticSnapshotPolicyEnabled`` = ``automaticSnapshotPolicyEnabled``
                ``changeFeed`` = ``changeFeed``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type LastAccessTimeTrackingPolicy =
        {
            /// When set to true last access time based tracking is enabled.
            ``enable`` : bool
            /// The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1
            ``trackingGranularityInDays`` : int option
            /// An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only
            ``blobType`` : string array option
        }
        static member create(``enable``, ?``trackingGranularityInDays``, ?``blobType``) =
            {
                ``enable`` = ``enable``
                ``trackingGranularityInDays`` = ``trackingGranularityInDays``
                ``blobType`` = ``blobType``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type RestorePolicyProperties =
        {
            /// Blob restore is enabled if set to true.
            ``enabled`` : bool
            /// how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.
            ``days`` : int option
            /// Deprecated in favor of minRestoreTime property.
            ``lastEnabledTime`` : string option
            /// Returns the minimum date and time that the restore can be started.
            ``minRestoreTime`` : string option
        }
        static member create(``enabled``, ?``days``, ?``lastEnabledTime``, ?``minRestoreTime``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``minRestoreTime`` = ``minRestoreTime``
            }
    type ChangeFeed =
        {
            /// Indicates whether change feed event logging is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the duration of changeFeed retention in days. Minimum value is 1 day and maximum value is 146000 days (400 years). A null value indicates an infinite retention of the change feed.
            ``retentionInDays`` : int option
        }
        static member create(?``enabled``, ?``retentionInDays``) =
            {
                ``enabled`` = ``enabled``
                ``retentionInDays`` = ``retentionInDays``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Versioning is enabled if set to true.
            ``isVersioningEnabled`` : bool option
            /// Deprecated in favor of isVersioningEnabled property.
            ``automaticSnapshotPolicyEnabled`` : bool option
            /// The blob service properties for change feed events.
            ``changeFeed`` : ChangeFeed option
            /// The blob service properties for blob restore policy
            ``restorePolicy`` : RestorePolicyProperties option
            /// The service properties for soft delete.
            ``containerDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// The blob service properties for Last access time based tracking policy.
            ``lastAccessTimeTrackingPolicy`` : LastAccessTimeTrackingPolicy option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``, ?``isVersioningEnabled``, ?``automaticSnapshotPolicyEnabled``, ?``changeFeed``, ?``restorePolicy``, ?``containerDeleteRetentionPolicy``, ?``lastAccessTimeTrackingPolicy``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
                ``isVersioningEnabled`` = ``isVersioningEnabled``
                ``automaticSnapshotPolicyEnabled`` = ``automaticSnapshotPolicyEnabled``
                ``changeFeed`` = ``changeFeed``
                ``restorePolicy`` = ``restorePolicy``
                ``containerDeleteRetentionPolicy`` = ``containerDeleteRetentionPolicy``
                ``lastAccessTimeTrackingPolicy`` = ``lastAccessTimeTrackingPolicy``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
module ``2020-08-01-preview`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type LastAccessTimeTrackingPolicy =
        {
            /// When set to true last access time based tracking is enabled.
            ``enable`` : bool
            /// The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1
            ``trackingGranularityInDays`` : int option
            /// An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only
            ``blobType`` : string array option
        }
        static member create(``enable``, ?``trackingGranularityInDays``, ?``blobType``) =
            {
                ``enable`` = ``enable``
                ``trackingGranularityInDays`` = ``trackingGranularityInDays``
                ``blobType`` = ``blobType``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type RestorePolicyProperties =
        {
            /// Blob restore is enabled if set to true.
            ``enabled`` : bool
            /// how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.
            ``days`` : int option
            /// Deprecated in favor of minRestoreTime property.
            ``lastEnabledTime`` : string option
            /// Returns the minimum date and time that the restore can be started.
            ``minRestoreTime`` : string option
        }
        static member create(``enabled``, ?``days``, ?``lastEnabledTime``, ?``minRestoreTime``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``minRestoreTime`` = ``minRestoreTime``
            }
    type ChangeFeed =
        {
            /// Indicates whether change feed event logging is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the duration of changeFeed retention in days. Minimum value is 1 day and maximum value is 146000 days (400 years). A null value indicates an infinite retention of the change feed.
            ``retentionInDays`` : int option
        }
        static member create(?``enabled``, ?``retentionInDays``) =
            {
                ``enabled`` = ``enabled``
                ``retentionInDays`` = ``retentionInDays``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Versioning is enabled if set to true.
            ``isVersioningEnabled`` : bool option
            /// Deprecated in favor of isVersioningEnabled property.
            ``automaticSnapshotPolicyEnabled`` : bool option
            /// The blob service properties for change feed events.
            ``changeFeed`` : ChangeFeed option
            /// The blob service properties for blob restore policy
            ``restorePolicy`` : RestorePolicyProperties option
            /// The service properties for soft delete.
            ``containerDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// The blob service properties for Last access time based tracking policy.
            ``lastAccessTimeTrackingPolicy`` : LastAccessTimeTrackingPolicy option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``, ?``isVersioningEnabled``, ?``automaticSnapshotPolicyEnabled``, ?``changeFeed``, ?``restorePolicy``, ?``containerDeleteRetentionPolicy``, ?``lastAccessTimeTrackingPolicy``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
                ``isVersioningEnabled`` = ``isVersioningEnabled``
                ``automaticSnapshotPolicyEnabled`` = ``automaticSnapshotPolicyEnabled``
                ``changeFeed`` = ``changeFeed``
                ``restorePolicy`` = ``restorePolicy``
                ``containerDeleteRetentionPolicy`` = ``containerDeleteRetentionPolicy``
                ``lastAccessTimeTrackingPolicy`` = ``lastAccessTimeTrackingPolicy``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
module ``2021-01-01`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type LastAccessTimeTrackingPolicy =
        {
            /// When set to true last access time based tracking is enabled.
            ``enable`` : bool
            /// The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1
            ``trackingGranularityInDays`` : int option
            /// An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only
            ``blobType`` : string array option
        }
        static member create(``enable``, ?``trackingGranularityInDays``, ?``blobType``) =
            {
                ``enable`` = ``enable``
                ``trackingGranularityInDays`` = ``trackingGranularityInDays``
                ``blobType`` = ``blobType``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type RestorePolicyProperties =
        {
            /// Blob restore is enabled if set to true.
            ``enabled`` : bool
            /// how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.
            ``days`` : int option
            /// Deprecated in favor of minRestoreTime property.
            ``lastEnabledTime`` : string option
            /// Returns the minimum date and time that the restore can be started.
            ``minRestoreTime`` : string option
        }
        static member create(``enabled``, ?``days``, ?``lastEnabledTime``, ?``minRestoreTime``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``minRestoreTime`` = ``minRestoreTime``
            }
    type ChangeFeed =
        {
            /// Indicates whether change feed event logging is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the duration of changeFeed retention in days. Minimum value is 1 day and maximum value is 146000 days (400 years). A null value indicates an infinite retention of the change feed.
            ``retentionInDays`` : int option
        }
        static member create(?``enabled``, ?``retentionInDays``) =
            {
                ``enabled`` = ``enabled``
                ``retentionInDays`` = ``retentionInDays``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Versioning is enabled if set to true.
            ``isVersioningEnabled`` : bool option
            /// Deprecated in favor of isVersioningEnabled property.
            ``automaticSnapshotPolicyEnabled`` : bool option
            /// The blob service properties for change feed events.
            ``changeFeed`` : ChangeFeed option
            /// The blob service properties for blob restore policy
            ``restorePolicy`` : RestorePolicyProperties option
            /// The service properties for soft delete.
            ``containerDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// The blob service properties for Last access time based tracking policy.
            ``lastAccessTimeTrackingPolicy`` : LastAccessTimeTrackingPolicy option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``, ?``isVersioningEnabled``, ?``automaticSnapshotPolicyEnabled``, ?``changeFeed``, ?``restorePolicy``, ?``containerDeleteRetentionPolicy``, ?``lastAccessTimeTrackingPolicy``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
                ``isVersioningEnabled`` = ``isVersioningEnabled``
                ``automaticSnapshotPolicyEnabled`` = ``automaticSnapshotPolicyEnabled``
                ``changeFeed`` = ``changeFeed``
                ``restorePolicy`` = ``restorePolicy``
                ``containerDeleteRetentionPolicy`` = ``containerDeleteRetentionPolicy``
                ``lastAccessTimeTrackingPolicy`` = ``lastAccessTimeTrackingPolicy``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
module ``2021-02-01`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type LastAccessTimeTrackingPolicy =
        {
            /// When set to true last access time based tracking is enabled.
            ``enable`` : bool
            /// The field specifies blob object tracking granularity in days, typically how often the blob object should be tracked.This field is currently read only with value as 1
            ``trackingGranularityInDays`` : int option
            /// An array of predefined supported blob types. Only blockBlob is the supported value. This field is currently read only
            ``blobType`` : string array option
        }
        static member create(``enable``, ?``trackingGranularityInDays``, ?``blobType``) =
            {
                ``enable`` = ``enable``
                ``trackingGranularityInDays`` = ``trackingGranularityInDays``
                ``blobType`` = ``blobType``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type RestorePolicyProperties =
        {
            /// Blob restore is enabled if set to true.
            ``enabled`` : bool
            /// how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days.
            ``days`` : int option
            /// Deprecated in favor of minRestoreTime property.
            ``lastEnabledTime`` : string option
            /// Returns the minimum date and time that the restore can be started.
            ``minRestoreTime`` : string option
        }
        static member create(``enabled``, ?``days``, ?``lastEnabledTime``, ?``minRestoreTime``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
                ``lastEnabledTime`` = ``lastEnabledTime``
                ``minRestoreTime`` = ``minRestoreTime``
            }
    type ChangeFeed =
        {
            /// Indicates whether change feed event logging is enabled for the Blob service.
            ``enabled`` : bool option
            /// Indicates the duration of changeFeed retention in days. Minimum value is 1 day and maximum value is 146000 days (400 years). A null value indicates an infinite retention of the change feed.
            ``retentionInDays`` : int option
        }
        static member create(?``enabled``, ?``retentionInDays``) =
            {
                ``enabled`` = ``enabled``
                ``retentionInDays`` = ``retentionInDays``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
            ``defaultServiceVersion`` : string option
            /// The service properties for soft delete.
            ``deleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Versioning is enabled if set to true.
            ``isVersioningEnabled`` : bool option
            /// Deprecated in favor of isVersioningEnabled property.
            ``automaticSnapshotPolicyEnabled`` : bool option
            /// The blob service properties for change feed events.
            ``changeFeed`` : ChangeFeed option
            /// The blob service properties for blob restore policy
            ``restorePolicy`` : RestorePolicyProperties option
            /// The service properties for soft delete.
            ``containerDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// The blob service properties for Last access time based tracking policy.
            ``lastAccessTimeTrackingPolicy`` : LastAccessTimeTrackingPolicy option
        }
        static member create(?``cors``, ?``defaultServiceVersion``, ?``deleteRetentionPolicy``, ?``isVersioningEnabled``, ?``automaticSnapshotPolicyEnabled``, ?``changeFeed``, ?``restorePolicy``, ?``containerDeleteRetentionPolicy``, ?``lastAccessTimeTrackingPolicy``) =
            {
                ``cors`` = ``cors``
                ``defaultServiceVersion`` = ``defaultServiceVersion``
                ``deleteRetentionPolicy`` = ``deleteRetentionPolicy``
                ``isVersioningEnabled`` = ``isVersioningEnabled``
                ``automaticSnapshotPolicyEnabled`` = ``automaticSnapshotPolicyEnabled``
                ``changeFeed`` = ``changeFeed``
                ``restorePolicy`` = ``restorePolicy``
                ``containerDeleteRetentionPolicy`` = ``containerDeleteRetentionPolicy``
                ``lastAccessTimeTrackingPolicy`` = ``lastAccessTimeTrackingPolicy``
            }
    type BlobService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Blob service.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
namespace Microsoft.Storage.StorageAccounts.BlobServices.Containers

module ``2018-02-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2018-03-01-preview`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2018-07-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2018-11-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2019-04-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// The version of the deleted blob container.
            ``version`` : string option
            /// Indicates whether the blob container was deleted.
            ``deleted`` : bool option
            /// Blob container deletion time.
            ``deletedTime`` : string option
            /// Remaining retention days for soft deleted blob container.
            ``remainingRetentionDays`` : int option
            /// Default the container to use specified encryption scope for all writes.
            ``defaultEncryptionScope`` : string option
            /// Block override of encryption scope from the container default.
            ``denyEncryptionScopeOverride`` : bool option
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``defaultEncryptionScope``, ?``denyEncryptionScopeOverride``, ?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``defaultEncryptionScope`` = ``defaultEncryptionScope``
                ``denyEncryptionScopeOverride`` = ``denyEncryptionScopeOverride``
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// The version of the deleted blob container.
            ``version`` : string option
            /// Indicates whether the blob container was deleted.
            ``deleted`` : bool option
            /// Blob container deletion time.
            ``deletedTime`` : string option
            /// Remaining retention days for soft deleted blob container.
            ``remainingRetentionDays`` : int option
            /// Default the container to use specified encryption scope for all writes.
            ``defaultEncryptionScope`` : string option
            /// Block override of encryption scope from the container default.
            ``denyEncryptionScopeOverride`` : bool option
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``defaultEncryptionScope``, ?``denyEncryptionScopeOverride``, ?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``defaultEncryptionScope`` = ``defaultEncryptionScope``
                ``denyEncryptionScopeOverride`` = ``denyEncryptionScopeOverride``
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// The version of the deleted blob container.
            ``version`` : string option
            /// Indicates whether the blob container was deleted.
            ``deleted`` : bool option
            /// Blob container deletion time.
            ``deletedTime`` : string option
            /// Remaining retention days for soft deleted blob container.
            ``remainingRetentionDays`` : int option
            /// Default the container to use specified encryption scope for all writes.
            ``defaultEncryptionScope`` : string option
            /// Block override of encryption scope from the container default.
            ``denyEncryptionScopeOverride`` : bool option
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``defaultEncryptionScope``, ?``denyEncryptionScopeOverride``, ?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``defaultEncryptionScope`` = ``defaultEncryptionScope``
                ``denyEncryptionScopeOverride`` = ``denyEncryptionScopeOverride``
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type TagProperty =
        {
            /// The tag value.
            ``tag`` : string option
            /// Returns the date and time the tag was added.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who added the tag.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who added the tag.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who added the tag.
            ``upn`` : string option
        }
        static member create(?``tag``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``tag`` = ``tag``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type LegalHoldProperties =
        {
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The list of LegalHold tags of a blob container.
            ``tags`` : TagProperty array option
        }
        static member create(?``hasLegalHold``, ?``tags``) =
            {
                ``hasLegalHold`` = ``hasLegalHold``
                ``tags`` = ``tags``
            }
    type UpdateHistoryProperty =
        {
            /// The ImmutabilityPolicy update type of a blob container,
            ``update`` : obj // Update option
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// Returns the date and time the ImmutabilityPolicy was updated.
            ``timestamp`` : string option
            /// Returns the Object ID of the user who updated the ImmutabilityPolicy.
            ``objectIdentifier`` : string option
            /// Returns the Tenant ID that issued the token for the user who updated the ImmutabilityPolicy.
            ``tenantId`` : string option
            /// Returns the User Principal Name of the user who updated the ImmutabilityPolicy.
            ``upn`` : string option
        }
        static member create(?``update``, ?``immutabilityPeriodSinceCreationInDays``, ?``timestamp``, ?``objectIdentifier``, ?``tenantId``, ?``upn``) =
            {
                ``update`` = ``update``
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``timestamp`` = ``timestamp``
                ``objectIdentifier`` = ``objectIdentifier``
                ``tenantId`` = ``tenantId``
                ``upn`` = ``upn``
            }
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicyProperties =
        {
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty option
            /// ImmutabilityPolicy Etag.
            ``etag`` : string option
            /// The ImmutabilityPolicy update history of the blob container.
            ``updateHistory`` : UpdateHistoryProperty array option
        }
        static member create(?``properties``, ?``etag``, ?``updateHistory``) =
            {
                ``properties`` = ``properties``
                ``etag`` = ``etag``
                ``updateHistory`` = ``updateHistory``
            }
    type ContainerProperties =
        {
            /// The version of the deleted blob container.
            ``version`` : string option
            /// Indicates whether the blob container was deleted.
            ``deleted`` : bool option
            /// Blob container deletion time.
            ``deletedTime`` : string option
            /// Remaining retention days for soft deleted blob container.
            ``remainingRetentionDays`` : int option
            /// Default the container to use specified encryption scope for all writes.
            ``defaultEncryptionScope`` : string option
            /// Block override of encryption scope from the container default.
            ``denyEncryptionScopeOverride`` : bool option
            /// Specifies whether data in the container may be accessed publicly and the level of access.
            ``publicAccess`` : obj // PublicAccess option
            /// Returns the date and time the container was last modified.
            ``lastModifiedTime`` : string option
            /// The lease status of the container.
            ``leaseStatus`` : obj // LeaseStatus option
            /// Lease state of the container.
            ``leaseState`` : obj // LeaseState option
            /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
            ``leaseDuration`` : obj // LeaseDuration option
            /// A name-value pair to associate with the container as metadata.
            ``metadata`` : Map<string, string> option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``immutabilityPolicy`` : ImmutabilityPolicyProperties option
            /// The LegalHold property of a blob container.
            ``legalHold`` : LegalHoldProperties option
            /// The hasLegalHold public property is set to true by SRP if there are at least one existing tag. The hasLegalHold public property is set to false by SRP if all existing legal hold tags are cleared out. There can be a maximum of 1000 blob containers with hasLegalHold=true for a given account.
            ``hasLegalHold`` : bool option
            /// The hasImmutabilityPolicy public property is set to true by SRP if ImmutabilityPolicy has been created for this container. The hasImmutabilityPolicy public property is set to false by SRP if ImmutabilityPolicy has not been created for this container.
            ``hasImmutabilityPolicy`` : bool option
        }
        static member create(?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``defaultEncryptionScope``, ?``denyEncryptionScopeOverride``, ?``publicAccess``, ?``lastModifiedTime``, ?``leaseStatus``, ?``leaseState``, ?``leaseDuration``, ?``metadata``, ?``immutabilityPolicy``, ?``legalHold``, ?``hasLegalHold``, ?``hasImmutabilityPolicy``) =
            {
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``defaultEncryptionScope`` = ``defaultEncryptionScope``
                ``denyEncryptionScopeOverride`` = ``denyEncryptionScopeOverride``
                ``publicAccess`` = ``publicAccess``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``leaseStatus`` = ``leaseStatus``
                ``leaseState`` = ``leaseState``
                ``leaseDuration`` = ``leaseDuration``
                ``metadata`` = ``metadata``
                ``immutabilityPolicy`` = ``immutabilityPolicy``
                ``legalHold`` = ``legalHold``
                ``hasLegalHold`` = ``hasLegalHold``
                ``hasImmutabilityPolicy`` = ``hasImmutabilityPolicy``
            }
    type Container =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of a container.
            ``properties`` : ContainerProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.BlobServices.Containers.ImmutabilityPolicies

module ``2018-02-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2018-03-01-preview`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2018-07-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2018-11-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2019-04-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
        }
        static member create(``immutabilityPeriodSinceCreationInDays``, ?``state``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type ImmutabilityPolicyProperty =
        {
            /// The immutability period for the blobs in the container since the policy creation, in days.
            ``immutabilityPeriodSinceCreationInDays`` : int option
            /// The ImmutabilityPolicy state of a blob container,
            ``state`` : obj // State option
            /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API
            ``allowProtectedAppendWrites`` : bool option
        }
        static member create(?``immutabilityPeriodSinceCreationInDays``, ?``state``, ?``allowProtectedAppendWrites``) =
            {
                ``immutabilityPeriodSinceCreationInDays`` = ``immutabilityPeriodSinceCreationInDays``
                ``state`` = ``state``
                ``allowProtectedAppendWrites`` = ``allowProtectedAppendWrites``
            }
    type ImmutabilityPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of an ImmutabilityPolicy of a blob container.
            ``properties`` : ImmutabilityPolicyProperty
        }
        static member create(``name``, ``properties``, ?``id``, ?``etag``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.EncryptionScopes

module ``2019-06-01`` =
    type EncryptionScopeKeyVaultProperties =
        {
            /// The object identifier for a key vault key object. When applied, the encryption scope will use the key referenced by the identifier to enable customer-managed key support on this encryption scope.
            ``keyUri`` : string option
        }
        static member create(?``keyUri``) =
            {
                ``keyUri`` = ``keyUri``
            }
    type EncryptionScopeProperties =
        {
            /// The provider for the encryption scope. Possible values (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault.
            ``source`` : obj // Source option
            /// The state of the encryption scope. Possible values (case-insensitive):  Enabled, Disabled.
            ``state`` : obj // State option
            /// Gets the creation date and time of the encryption scope in UTC.
            ``creationTime`` : string option
            /// Gets the last modification date and time of the encryption scope in UTC.
            ``lastModifiedTime`` : string option
            /// The key vault properties for the encryption scope. This is a required field if encryption scope 'source' attribute is set to 'Microsoft.KeyVault'.
            ``keyVaultProperties`` : EncryptionScopeKeyVaultProperties option
        }
        static member create(?``source``, ?``state``, ?``creationTime``, ?``lastModifiedTime``, ?``keyVaultProperties``) =
            {
                ``source`` = ``source``
                ``state`` = ``state``
                ``creationTime`` = ``creationTime``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``keyVaultProperties`` = ``keyVaultProperties``
            }
    type EncryptionScope =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the encryption scope.
            ``properties`` : EncryptionScopeProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type EncryptionScopeKeyVaultProperties =
        {
            /// The object identifier for a key vault key object. When applied, the encryption scope will use the key referenced by the identifier to enable customer-managed key support on this encryption scope.
            ``keyUri`` : string option
        }
        static member create(?``keyUri``) =
            {
                ``keyUri`` = ``keyUri``
            }
    type EncryptionScopeProperties =
        {
            /// The provider for the encryption scope. Possible values (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault.
            ``source`` : obj // Source option
            /// The state of the encryption scope. Possible values (case-insensitive):  Enabled, Disabled.
            ``state`` : obj // State option
            /// Gets the creation date and time of the encryption scope in UTC.
            ``creationTime`` : string option
            /// Gets the last modification date and time of the encryption scope in UTC.
            ``lastModifiedTime`` : string option
            /// The key vault properties for the encryption scope. This is a required field if encryption scope 'source' attribute is set to 'Microsoft.KeyVault'.
            ``keyVaultProperties`` : EncryptionScopeKeyVaultProperties option
        }
        static member create(?``source``, ?``state``, ?``creationTime``, ?``lastModifiedTime``, ?``keyVaultProperties``) =
            {
                ``source`` = ``source``
                ``state`` = ``state``
                ``creationTime`` = ``creationTime``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``keyVaultProperties`` = ``keyVaultProperties``
            }
    type EncryptionScope =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the encryption scope.
            ``properties`` : EncryptionScopeProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type EncryptionScopeKeyVaultProperties =
        {
            /// The object identifier for a key vault key object. When applied, the encryption scope will use the key referenced by the identifier to enable customer-managed key support on this encryption scope.
            ``keyUri`` : string option
            /// The object identifier of the current versioned Key Vault Key in use.
            ``currentVersionedKeyIdentifier`` : string option
            /// Timestamp of last rotation of the Key Vault Key.
            ``lastKeyRotationTimestamp`` : string option
        }
        static member create(?``keyUri``, ?``currentVersionedKeyIdentifier``, ?``lastKeyRotationTimestamp``) =
            {
                ``keyUri`` = ``keyUri``
                ``currentVersionedKeyIdentifier`` = ``currentVersionedKeyIdentifier``
                ``lastKeyRotationTimestamp`` = ``lastKeyRotationTimestamp``
            }
    type EncryptionScopeProperties =
        {
            /// The provider for the encryption scope. Possible values (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault.
            ``source`` : obj // Source option
            /// The state of the encryption scope. Possible values (case-insensitive):  Enabled, Disabled.
            ``state`` : obj // State option
            /// Gets the creation date and time of the encryption scope in UTC.
            ``creationTime`` : string option
            /// Gets the last modification date and time of the encryption scope in UTC.
            ``lastModifiedTime`` : string option
            /// The key vault properties for the encryption scope. This is a required field if encryption scope 'source' attribute is set to 'Microsoft.KeyVault'.
            ``keyVaultProperties`` : EncryptionScopeKeyVaultProperties option
            /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
            ``requireInfrastructureEncryption`` : bool option
        }
        static member create(?``source``, ?``state``, ?``creationTime``, ?``lastModifiedTime``, ?``keyVaultProperties``, ?``requireInfrastructureEncryption``) =
            {
                ``source`` = ``source``
                ``state`` = ``state``
                ``creationTime`` = ``creationTime``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``keyVaultProperties`` = ``keyVaultProperties``
                ``requireInfrastructureEncryption`` = ``requireInfrastructureEncryption``
            }
    type EncryptionScope =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the encryption scope.
            ``properties`` : EncryptionScopeProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type EncryptionScopeKeyVaultProperties =
        {
            /// The object identifier for a key vault key object. When applied, the encryption scope will use the key referenced by the identifier to enable customer-managed key support on this encryption scope.
            ``keyUri`` : string option
            /// The object identifier of the current versioned Key Vault Key in use.
            ``currentVersionedKeyIdentifier`` : string option
            /// Timestamp of last rotation of the Key Vault Key.
            ``lastKeyRotationTimestamp`` : string option
        }
        static member create(?``keyUri``, ?``currentVersionedKeyIdentifier``, ?``lastKeyRotationTimestamp``) =
            {
                ``keyUri`` = ``keyUri``
                ``currentVersionedKeyIdentifier`` = ``currentVersionedKeyIdentifier``
                ``lastKeyRotationTimestamp`` = ``lastKeyRotationTimestamp``
            }
    type EncryptionScopeProperties =
        {
            /// The provider for the encryption scope. Possible values (case-insensitive):  Microsoft.Storage, Microsoft.KeyVault.
            ``source`` : obj // Source option
            /// The state of the encryption scope. Possible values (case-insensitive):  Enabled, Disabled.
            ``state`` : obj // State option
            /// Gets the creation date and time of the encryption scope in UTC.
            ``creationTime`` : string option
            /// Gets the last modification date and time of the encryption scope in UTC.
            ``lastModifiedTime`` : string option
            /// The key vault properties for the encryption scope. This is a required field if encryption scope 'source' attribute is set to 'Microsoft.KeyVault'.
            ``keyVaultProperties`` : EncryptionScopeKeyVaultProperties option
            /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
            ``requireInfrastructureEncryption`` : bool option
        }
        static member create(?``source``, ?``state``, ?``creationTime``, ?``lastModifiedTime``, ?``keyVaultProperties``, ?``requireInfrastructureEncryption``) =
            {
                ``source`` = ``source``
                ``state`` = ``state``
                ``creationTime`` = ``creationTime``
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``keyVaultProperties`` = ``keyVaultProperties``
                ``requireInfrastructureEncryption`` = ``requireInfrastructureEncryption``
            }
    type EncryptionScope =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the encryption scope.
            ``properties`` : EncryptionScopeProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.FileServices

module ``2019-04-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type FileService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of File services in storage account.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// The service properties for soft delete.
            ``shareDeleteRetentionPolicy`` : DeleteRetentionPolicy option
        }
        static member create(?``cors``, ?``shareDeleteRetentionPolicy``) =
            {
                ``cors`` = ``cors``
                ``shareDeleteRetentionPolicy`` = ``shareDeleteRetentionPolicy``
            }
    type FileService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of File services in storage account.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
module ``2020-08-01-preview`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type Multichannel =
        {
            /// Indicates whether multichannel is enabled
            ``enabled`` : bool option
        }
        static member create(?``enabled``) =
            {
                ``enabled`` = ``enabled``
            }
    type SmbSetting =
        {
            /// Multichannel setting. Applies to Premium FileStorage only.
            ``multichannel`` : Multichannel option
        }
        static member create(?``multichannel``) =
            {
                ``multichannel`` = ``multichannel``
            }
    type ProtocolSettings =
        {
            /// Setting for SMB protocol
            ``smb`` : SmbSetting option
        }
        static member create(?``smb``) =
            {
                ``smb`` = ``smb``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// The service properties for soft delete.
            ``shareDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Protocol settings for file service
            ``protocolSettings`` : ProtocolSettings option
        }
        static member create(?``cors``, ?``shareDeleteRetentionPolicy``, ?``protocolSettings``) =
            {
                ``cors`` = ``cors``
                ``shareDeleteRetentionPolicy`` = ``shareDeleteRetentionPolicy``
                ``protocolSettings`` = ``protocolSettings``
            }
    type FileService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of File services in storage account.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
module ``2021-01-01`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type Multichannel =
        {
            /// Indicates whether multichannel is enabled
            ``enabled`` : bool option
        }
        static member create(?``enabled``) =
            {
                ``enabled`` = ``enabled``
            }
    type SmbSetting =
        {
            /// Multichannel setting. Applies to Premium FileStorage only.
            ``multichannel`` : Multichannel option
            /// SMB protocol versions supported by server. Valid values are SMB2.1, SMB3.0, SMB3.1.1. Should be passed as a string with delimiter ';'.
            ``versions`` : string option
            /// SMB authentication methods supported by server. Valid values are NTLMv2, Kerberos. Should be passed as a string with delimiter ';'.
            ``authenticationMethods`` : string option
            /// Kerberos ticket encryption supported by server. Valid values are RC4-HMAC, AES-256. Should be passed as a string with delimiter ';'
            ``kerberosTicketEncryption`` : string option
            /// SMB channel encryption supported by server. Valid values are AES-128-CCM, AES-128-GCM, AES-256-GCM. Should be passed as a string with delimiter ';'.
            ``channelEncryption`` : string option
        }
        static member create(?``multichannel``, ?``versions``, ?``authenticationMethods``, ?``kerberosTicketEncryption``, ?``channelEncryption``) =
            {
                ``multichannel`` = ``multichannel``
                ``versions`` = ``versions``
                ``authenticationMethods`` = ``authenticationMethods``
                ``kerberosTicketEncryption`` = ``kerberosTicketEncryption``
                ``channelEncryption`` = ``channelEncryption``
            }
    type ProtocolSettings =
        {
            /// Setting for SMB protocol
            ``smb`` : SmbSetting option
        }
        static member create(?``smb``) =
            {
                ``smb`` = ``smb``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// The service properties for soft delete.
            ``shareDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Protocol settings for file service
            ``protocolSettings`` : ProtocolSettings option
        }
        static member create(?``cors``, ?``shareDeleteRetentionPolicy``, ?``protocolSettings``) =
            {
                ``cors`` = ``cors``
                ``shareDeleteRetentionPolicy`` = ``shareDeleteRetentionPolicy``
                ``protocolSettings`` = ``protocolSettings``
            }
    type FileService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of File services in storage account.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
module ``2021-02-01`` =
    type Sku =
        {
            ``name`` : obj // Name
            ``tier`` : obj // Tier option
        }
        static member create(``name``, ?``tier``) =
            {
                ``name`` = ``name``
                ``tier`` = ``tier``
            }
    type Multichannel =
        {
            /// Indicates whether multichannel is enabled
            ``enabled`` : bool option
        }
        static member create(?``enabled``) =
            {
                ``enabled`` = ``enabled``
            }
    type SmbSetting =
        {
            /// Multichannel setting. Applies to Premium FileStorage only.
            ``multichannel`` : Multichannel option
            /// SMB protocol versions supported by server. Valid values are SMB2.1, SMB3.0, SMB3.1.1. Should be passed as a string with delimiter ';'.
            ``versions`` : string option
            /// SMB authentication methods supported by server. Valid values are NTLMv2, Kerberos. Should be passed as a string with delimiter ';'.
            ``authenticationMethods`` : string option
            /// Kerberos ticket encryption supported by server. Valid values are RC4-HMAC, AES-256. Should be passed as a string with delimiter ';'
            ``kerberosTicketEncryption`` : string option
            /// SMB channel encryption supported by server. Valid values are AES-128-CCM, AES-128-GCM, AES-256-GCM. Should be passed as a string with delimiter ';'.
            ``channelEncryption`` : string option
        }
        static member create(?``multichannel``, ?``versions``, ?``authenticationMethods``, ?``kerberosTicketEncryption``, ?``channelEncryption``) =
            {
                ``multichannel`` = ``multichannel``
                ``versions`` = ``versions``
                ``authenticationMethods`` = ``authenticationMethods``
                ``kerberosTicketEncryption`` = ``kerberosTicketEncryption``
                ``channelEncryption`` = ``channelEncryption``
            }
    type ProtocolSettings =
        {
            /// Setting for SMB protocol
            ``smb`` : SmbSetting option
        }
        static member create(?``smb``) =
            {
                ``smb`` = ``smb``
            }
    type DeleteRetentionPolicy =
        {
            /// Indicates whether DeleteRetentionPolicy is enabled.
            ``enabled`` : bool option
            /// Indicates the number of days that the deleted item should be retained. The minimum specified value can be 1 and the maximum value can be 365.
            ``days`` : int option
        }
        static member create(?``enabled``, ?``days``) =
            {
                ``enabled`` = ``enabled``
                ``days`` = ``days``
            }
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
            /// The service properties for soft delete.
            ``shareDeleteRetentionPolicy`` : DeleteRetentionPolicy option
            /// Protocol settings for file service
            ``protocolSettings`` : ProtocolSettings option
        }
        static member create(?``cors``, ?``shareDeleteRetentionPolicy``, ?``protocolSettings``) =
            {
                ``cors`` = ``cors``
                ``shareDeleteRetentionPolicy`` = ``shareDeleteRetentionPolicy``
                ``protocolSettings`` = ``protocolSettings``
            }
    type FileService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of File services in storage account.
            ``properties`` : Properties option
            /// The SKU of the storage account.
            ``sku`` : Sku option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``sku``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``sku`` = ``sku``
            }
namespace Microsoft.Storage.StorageAccounts.FileServices.Shares

module ``2019-04-01`` =
    type FileShareProperties =
        {
            /// Returns the date and time the share was last modified.
            ``lastModifiedTime`` : string option
            /// A name-value pair to associate with the share as metadata.
            ``metadata`` : Map<string, string> option
            /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120).
            ``shareQuota`` : int option
        }
        static member create(?``lastModifiedTime``, ?``metadata``, ?``shareQuota``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``metadata`` = ``metadata``
                ``shareQuota`` = ``shareQuota``
            }
    type Share =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of the file share.
            ``properties`` : FileShareProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type FileShareProperties =
        {
            /// Returns the date and time the share was last modified.
            ``lastModifiedTime`` : string option
            /// A name-value pair to associate with the share as metadata.
            ``metadata`` : Map<string, string> option
            /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
            ``shareQuota`` : int option
            /// The authentication protocol that is used for the file share. Can only be specified when creating a share.
            ``enabledProtocols`` : obj // EnabledProtocols option
            /// The property is for NFS share only. The default is NoRootSquash.
            ``rootSquash`` : obj // RootSquash option
            /// The version of the share.
            ``version`` : string option
            /// Indicates whether the share was deleted.
            ``deleted`` : bool option
            /// The deleted time if the share was deleted.
            ``deletedTime`` : string option
            /// Remaining retention days for share that was soft deleted.
            ``remainingRetentionDays`` : int option
            /// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
            ``accessTier`` : obj // AccessTier option
            /// Indicates the last modification time for share access tier.
            ``accessTierChangeTime`` : string option
            /// Indicates if there is a pending transition for access tier.
            ``accessTierStatus`` : string option
            /// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
            ``shareUsageBytes`` : int option
        }
        static member create(?``lastModifiedTime``, ?``metadata``, ?``shareQuota``, ?``enabledProtocols``, ?``rootSquash``, ?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``accessTier``, ?``accessTierChangeTime``, ?``accessTierStatus``, ?``shareUsageBytes``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``metadata`` = ``metadata``
                ``shareQuota`` = ``shareQuota``
                ``enabledProtocols`` = ``enabledProtocols``
                ``rootSquash`` = ``rootSquash``
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``accessTier`` = ``accessTier``
                ``accessTierChangeTime`` = ``accessTierChangeTime``
                ``accessTierStatus`` = ``accessTierStatus``
                ``shareUsageBytes`` = ``shareUsageBytes``
            }
    type Share =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of the file share.
            ``properties`` : FileShareProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type FileShareProperties =
        {
            /// Returns the date and time the share was last modified.
            ``lastModifiedTime`` : string option
            /// A name-value pair to associate with the share as metadata.
            ``metadata`` : Map<string, string> option
            /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
            ``shareQuota`` : int option
            /// The authentication protocol that is used for the file share. Can only be specified when creating a share.
            ``enabledProtocols`` : obj // EnabledProtocols option
            /// The property is for NFS share only. The default is NoRootSquash.
            ``rootSquash`` : obj // RootSquash option
            /// The version of the share.
            ``version`` : string option
            /// Indicates whether the share was deleted.
            ``deleted`` : bool option
            /// The deleted time if the share was deleted.
            ``deletedTime`` : string option
            /// Remaining retention days for share that was soft deleted.
            ``remainingRetentionDays`` : int option
            /// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
            ``accessTier`` : obj // AccessTier option
            /// Indicates the last modification time for share access tier.
            ``accessTierChangeTime`` : string option
            /// Indicates if there is a pending transition for access tier.
            ``accessTierStatus`` : string option
            /// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
            ``shareUsageBytes`` : int option
            /// Creation time of share snapshot returned in the response of list shares with expand param "snapshots".
            ``snapshotTime`` : string option
        }
        static member create(?``lastModifiedTime``, ?``metadata``, ?``shareQuota``, ?``enabledProtocols``, ?``rootSquash``, ?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``accessTier``, ?``accessTierChangeTime``, ?``accessTierStatus``, ?``shareUsageBytes``, ?``snapshotTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``metadata`` = ``metadata``
                ``shareQuota`` = ``shareQuota``
                ``enabledProtocols`` = ``enabledProtocols``
                ``rootSquash`` = ``rootSquash``
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``accessTier`` = ``accessTier``
                ``accessTierChangeTime`` = ``accessTierChangeTime``
                ``accessTierStatus`` = ``accessTierStatus``
                ``shareUsageBytes`` = ``shareUsageBytes``
                ``snapshotTime`` = ``snapshotTime``
            }
    type Share =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of the file share.
            ``properties`` : FileShareProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type FileShareProperties =
        {
            /// Returns the date and time the share was last modified.
            ``lastModifiedTime`` : string option
            /// A name-value pair to associate with the share as metadata.
            ``metadata`` : Map<string, string> option
            /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
            ``shareQuota`` : int option
            /// The authentication protocol that is used for the file share. Can only be specified when creating a share.
            ``enabledProtocols`` : obj // EnabledProtocols option
            /// The property is for NFS share only. The default is NoRootSquash.
            ``rootSquash`` : obj // RootSquash option
            /// The version of the share.
            ``version`` : string option
            /// Indicates whether the share was deleted.
            ``deleted`` : bool option
            /// The deleted time if the share was deleted.
            ``deletedTime`` : string option
            /// Remaining retention days for share that was soft deleted.
            ``remainingRetentionDays`` : int option
            /// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
            ``accessTier`` : obj // AccessTier option
            /// Indicates the last modification time for share access tier.
            ``accessTierChangeTime`` : string option
            /// Indicates if there is a pending transition for access tier.
            ``accessTierStatus`` : string option
            /// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
            ``shareUsageBytes`` : int option
            /// Creation time of share snapshot returned in the response of list shares with expand param "snapshots".
            ``snapshotTime`` : string option
        }
        static member create(?``lastModifiedTime``, ?``metadata``, ?``shareQuota``, ?``enabledProtocols``, ?``rootSquash``, ?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``accessTier``, ?``accessTierChangeTime``, ?``accessTierStatus``, ?``shareUsageBytes``, ?``snapshotTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``metadata`` = ``metadata``
                ``shareQuota`` = ``shareQuota``
                ``enabledProtocols`` = ``enabledProtocols``
                ``rootSquash`` = ``rootSquash``
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``accessTier`` = ``accessTier``
                ``accessTierChangeTime`` = ``accessTierChangeTime``
                ``accessTierStatus`` = ``accessTierStatus``
                ``shareUsageBytes`` = ``shareUsageBytes``
                ``snapshotTime`` = ``snapshotTime``
            }
    type Share =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of the file share.
            ``properties`` : FileShareProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type FileShareProperties =
        {
            /// Returns the date and time the share was last modified.
            ``lastModifiedTime`` : string option
            /// A name-value pair to associate with the share as metadata.
            ``metadata`` : Map<string, string> option
            /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
            ``shareQuota`` : int option
            /// The authentication protocol that is used for the file share. Can only be specified when creating a share.
            ``enabledProtocols`` : obj // EnabledProtocols option
            /// The property is for NFS share only. The default is NoRootSquash.
            ``rootSquash`` : obj // RootSquash option
            /// The version of the share.
            ``version`` : string option
            /// Indicates whether the share was deleted.
            ``deleted`` : bool option
            /// The deleted time if the share was deleted.
            ``deletedTime`` : string option
            /// Remaining retention days for share that was soft deleted.
            ``remainingRetentionDays`` : int option
            /// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
            ``accessTier`` : obj // AccessTier option
            /// Indicates the last modification time for share access tier.
            ``accessTierChangeTime`` : string option
            /// Indicates if there is a pending transition for access tier.
            ``accessTierStatus`` : string option
            /// The approximate size of the data stored on the share. Note that this value may not include all recently created or recently resized files.
            ``shareUsageBytes`` : int option
            /// Creation time of share snapshot returned in the response of list shares with expand param "snapshots".
            ``snapshotTime`` : string option
        }
        static member create(?``lastModifiedTime``, ?``metadata``, ?``shareQuota``, ?``enabledProtocols``, ?``rootSquash``, ?``version``, ?``deleted``, ?``deletedTime``, ?``remainingRetentionDays``, ?``accessTier``, ?``accessTierChangeTime``, ?``accessTierStatus``, ?``shareUsageBytes``, ?``snapshotTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``metadata`` = ``metadata``
                ``shareQuota`` = ``shareQuota``
                ``enabledProtocols`` = ``enabledProtocols``
                ``rootSquash`` = ``rootSquash``
                ``version`` = ``version``
                ``deleted`` = ``deleted``
                ``deletedTime`` = ``deletedTime``
                ``remainingRetentionDays`` = ``remainingRetentionDays``
                ``accessTier`` = ``accessTier``
                ``accessTierChangeTime`` = ``accessTierChangeTime``
                ``accessTierStatus`` = ``accessTierStatus``
                ``shareUsageBytes`` = ``shareUsageBytes``
                ``snapshotTime`` = ``snapshotTime``
            }
    type Share =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Resource Etag.
            ``etag`` : string option
            /// The properties of the file share.
            ``properties`` : FileShareProperties option
        }
        static member create(``name``, ?``id``, ?``etag``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``etag`` = ``etag``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.InventoryPolicies

module ``2019-06-01`` =
    type systemData =
        {
            /// The identity that created the resource.
            ``createdBy`` : string option
            /// The type of identity that created the resource.
            ``createdByType`` : obj // CreatedByType option
            /// The timestamp of resource creation (UTC).
            ``createdAt`` : string option
            /// The identity that last modified the resource.
            ``lastModifiedBy`` : string option
            /// The type of identity that last modified the resource.
            ``lastModifiedByType`` : obj // LastModifiedByType option
            /// The timestamp of resource last modification (UTC)
            ``lastModifiedAt`` : string option
        }
        static member create(?``createdBy``, ?``createdByType``, ?``createdAt``, ?``lastModifiedBy``, ?``lastModifiedByType``, ?``lastModifiedAt``) =
            {
                ``createdBy`` = ``createdBy``
                ``createdByType`` = ``createdByType``
                ``createdAt`` = ``createdAt``
                ``lastModifiedBy`` = ``lastModifiedBy``
                ``lastModifiedByType`` = ``lastModifiedByType``
                ``lastModifiedAt`` = ``lastModifiedAt``
            }
    type BlobInventoryPolicyFilter =
        {
            /// An array of strings for blob prefixes to be matched.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs.
            ``blobTypes`` : string array
            /// Includes blob versions in blob inventory when value set to true.
            ``includeBlobVersions`` : bool option
            /// Includes blob snapshots in blob inventory when value set to true.
            ``includeSnapshots`` : bool option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``includeBlobVersions``, ?``includeSnapshots``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``includeBlobVersions`` = ``includeBlobVersions``
                ``includeSnapshots`` = ``includeSnapshots``
            }
    type BlobInventoryPolicyDefinition =
        {
            /// An object that defines the blob inventory rule filter conditions.
            ``filters`` : BlobInventoryPolicyFilter
        }
        static member create(``filters``) =
            {
                ``filters`` = ``filters``
            }
    type BlobInventoryPolicyRule =
        {
            /// Rule is enabled when set to true.
            ``enabled`` : bool
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// An object that defines the blob inventory rule. Each definition consists of a set of filters.
            ``definition`` : BlobInventoryPolicyDefinition
        }
        static member create(``enabled``, ``name``, ``definition``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``definition`` = ``definition``
            }
    type BlobInventoryPolicySchema =
        {
            /// Policy is enabled if set to true.
            ``enabled`` : bool
            /// Container name where blob inventory files are stored. Must be pre-created.
            ``destination`` : string
            /// The valid value is Inventory
            ``type`` : string
            /// The storage account blob inventory policy rules. The rule is applied when it is enabled.
            ``rules`` : BlobInventoryPolicyRule array
        }
        static member create(``enabled``, ``destination``, ``type``, ``rules``) =
            {
                ``enabled`` = ``enabled``
                ``destination`` = ``destination``
                ``type`` = ``type``
                ``rules`` = ``rules``
            }
    type BlobInventoryPolicyProperties =
        {
            /// Returns the last modified date and time of the blob inventory policy.
            ``lastModifiedTime`` : string option
            /// The storage account blob inventory policy rules.
            ``policy`` : BlobInventoryPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type InventoryPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The storage account blob inventory policy properties.
            ``properties`` : BlobInventoryPolicyProperties option
            /// Metadata pertaining to creation and last modification of the resource.
            ``systemData`` : systemData option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``systemData``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``systemData`` = ``systemData``
            }
module ``2020-08-01-preview`` =
    type systemData =
        {
            /// The identity that created the resource.
            ``createdBy`` : string option
            /// The type of identity that created the resource.
            ``createdByType`` : obj // CreatedByType option
            /// The timestamp of resource creation (UTC).
            ``createdAt`` : string option
            /// The identity that last modified the resource.
            ``lastModifiedBy`` : string option
            /// The type of identity that last modified the resource.
            ``lastModifiedByType`` : obj // LastModifiedByType option
            /// The timestamp of resource last modification (UTC)
            ``lastModifiedAt`` : string option
        }
        static member create(?``createdBy``, ?``createdByType``, ?``createdAt``, ?``lastModifiedBy``, ?``lastModifiedByType``, ?``lastModifiedAt``) =
            {
                ``createdBy`` = ``createdBy``
                ``createdByType`` = ``createdByType``
                ``createdAt`` = ``createdAt``
                ``lastModifiedBy`` = ``lastModifiedBy``
                ``lastModifiedByType`` = ``lastModifiedByType``
                ``lastModifiedAt`` = ``lastModifiedAt``
            }
    type BlobInventoryPolicyFilter =
        {
            /// An array of strings for blob prefixes to be matched.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs.
            ``blobTypes`` : string array
            /// Includes blob versions in blob inventory when value set to true.
            ``includeBlobVersions`` : bool option
            /// Includes blob snapshots in blob inventory when value set to true.
            ``includeSnapshots`` : bool option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``includeBlobVersions``, ?``includeSnapshots``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``includeBlobVersions`` = ``includeBlobVersions``
                ``includeSnapshots`` = ``includeSnapshots``
            }
    type BlobInventoryPolicyDefinition =
        {
            /// An object that defines the blob inventory rule filter conditions.
            ``filters`` : BlobInventoryPolicyFilter
        }
        static member create(``filters``) =
            {
                ``filters`` = ``filters``
            }
    type BlobInventoryPolicyRule =
        {
            /// Rule is enabled when set to true.
            ``enabled`` : bool
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// An object that defines the blob inventory rule. Each definition consists of a set of filters.
            ``definition`` : BlobInventoryPolicyDefinition
        }
        static member create(``enabled``, ``name``, ``definition``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``definition`` = ``definition``
            }
    type BlobInventoryPolicySchema =
        {
            /// Policy is enabled if set to true.
            ``enabled`` : bool
            /// Container name where blob inventory files are stored. Must be pre-created.
            ``destination`` : string
            /// The valid value is Inventory
            ``type`` : string
            /// The storage account blob inventory policy rules. The rule is applied when it is enabled.
            ``rules`` : BlobInventoryPolicyRule array
        }
        static member create(``enabled``, ``destination``, ``type``, ``rules``) =
            {
                ``enabled`` = ``enabled``
                ``destination`` = ``destination``
                ``type`` = ``type``
                ``rules`` = ``rules``
            }
    type BlobInventoryPolicyProperties =
        {
            /// Returns the last modified date and time of the blob inventory policy.
            ``lastModifiedTime`` : string option
            /// The storage account blob inventory policy rules.
            ``policy`` : BlobInventoryPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type InventoryPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The storage account blob inventory policy properties.
            ``properties`` : BlobInventoryPolicyProperties option
            /// Metadata pertaining to creation and last modification of the resource.
            ``systemData`` : systemData option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``systemData``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``systemData`` = ``systemData``
            }
module ``2021-01-01`` =
    type systemData =
        {
            /// The identity that created the resource.
            ``createdBy`` : string option
            /// The type of identity that created the resource.
            ``createdByType`` : obj // CreatedByType option
            /// The timestamp of resource creation (UTC).
            ``createdAt`` : string option
            /// The identity that last modified the resource.
            ``lastModifiedBy`` : string option
            /// The type of identity that last modified the resource.
            ``lastModifiedByType`` : obj // LastModifiedByType option
            /// The timestamp of resource last modification (UTC)
            ``lastModifiedAt`` : string option
        }
        static member create(?``createdBy``, ?``createdByType``, ?``createdAt``, ?``lastModifiedBy``, ?``lastModifiedByType``, ?``lastModifiedAt``) =
            {
                ``createdBy`` = ``createdBy``
                ``createdByType`` = ``createdByType``
                ``createdAt`` = ``createdAt``
                ``lastModifiedBy`` = ``lastModifiedBy``
                ``lastModifiedByType`` = ``lastModifiedByType``
                ``lastModifiedAt`` = ``lastModifiedAt``
            }
    type BlobInventoryPolicyFilter =
        {
            /// An array of strings for blob prefixes to be matched.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs.
            ``blobTypes`` : string array
            /// Includes blob versions in blob inventory when value set to true.
            ``includeBlobVersions`` : bool option
            /// Includes blob snapshots in blob inventory when value set to true.
            ``includeSnapshots`` : bool option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``includeBlobVersions``, ?``includeSnapshots``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``includeBlobVersions`` = ``includeBlobVersions``
                ``includeSnapshots`` = ``includeSnapshots``
            }
    type BlobInventoryPolicyDefinition =
        {
            /// An object that defines the blob inventory rule filter conditions.
            ``filters`` : BlobInventoryPolicyFilter
        }
        static member create(``filters``) =
            {
                ``filters`` = ``filters``
            }
    type BlobInventoryPolicyRule =
        {
            /// Rule is enabled when set to true.
            ``enabled`` : bool
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// An object that defines the blob inventory rule. Each definition consists of a set of filters.
            ``definition`` : BlobInventoryPolicyDefinition
        }
        static member create(``enabled``, ``name``, ``definition``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``definition`` = ``definition``
            }
    type BlobInventoryPolicySchema =
        {
            /// Policy is enabled if set to true.
            ``enabled`` : bool
            /// Container name where blob inventory files are stored. Must be pre-created.
            ``destination`` : string
            /// The valid value is Inventory
            ``type`` : string
            /// The storage account blob inventory policy rules. The rule is applied when it is enabled.
            ``rules`` : BlobInventoryPolicyRule array
        }
        static member create(``enabled``, ``destination``, ``type``, ``rules``) =
            {
                ``enabled`` = ``enabled``
                ``destination`` = ``destination``
                ``type`` = ``type``
                ``rules`` = ``rules``
            }
    type BlobInventoryPolicyProperties =
        {
            /// Returns the last modified date and time of the blob inventory policy.
            ``lastModifiedTime`` : string option
            /// The storage account blob inventory policy rules.
            ``policy`` : BlobInventoryPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type InventoryPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The storage account blob inventory policy properties.
            ``properties`` : BlobInventoryPolicyProperties option
            /// Metadata pertaining to creation and last modification of the resource.
            ``systemData`` : systemData option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``systemData``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``systemData`` = ``systemData``
            }
module ``2021-02-01`` =
    type systemData =
        {
            /// The identity that created the resource.
            ``createdBy`` : string option
            /// The type of identity that created the resource.
            ``createdByType`` : obj // CreatedByType option
            /// The timestamp of resource creation (UTC).
            ``createdAt`` : string option
            /// The identity that last modified the resource.
            ``lastModifiedBy`` : string option
            /// The type of identity that last modified the resource.
            ``lastModifiedByType`` : obj // LastModifiedByType option
            /// The timestamp of resource last modification (UTC)
            ``lastModifiedAt`` : string option
        }
        static member create(?``createdBy``, ?``createdByType``, ?``createdAt``, ?``lastModifiedBy``, ?``lastModifiedByType``, ?``lastModifiedAt``) =
            {
                ``createdBy`` = ``createdBy``
                ``createdByType`` = ``createdByType``
                ``createdAt`` = ``createdAt``
                ``lastModifiedBy`` = ``lastModifiedBy``
                ``lastModifiedByType`` = ``lastModifiedByType``
                ``lastModifiedAt`` = ``lastModifiedAt``
            }
    type BlobInventoryPolicyFilter =
        {
            /// An array of strings for blob prefixes to be matched.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Valid values include blockBlob, appendBlob, pageBlob. Hns accounts does not support pageBlobs.
            ``blobTypes`` : string array
            /// Includes blob versions in blob inventory when value set to true.
            ``includeBlobVersions`` : bool option
            /// Includes blob snapshots in blob inventory when value set to true.
            ``includeSnapshots`` : bool option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``includeBlobVersions``, ?``includeSnapshots``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``includeBlobVersions`` = ``includeBlobVersions``
                ``includeSnapshots`` = ``includeSnapshots``
            }
    type BlobInventoryPolicyDefinition =
        {
            /// An object that defines the blob inventory rule filter conditions.
            ``filters`` : BlobInventoryPolicyFilter
        }
        static member create(``filters``) =
            {
                ``filters`` = ``filters``
            }
    type BlobInventoryPolicyRule =
        {
            /// Rule is enabled when set to true.
            ``enabled`` : bool
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// An object that defines the blob inventory rule. Each definition consists of a set of filters.
            ``definition`` : BlobInventoryPolicyDefinition
        }
        static member create(``enabled``, ``name``, ``definition``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``definition`` = ``definition``
            }
    type BlobInventoryPolicySchema =
        {
            /// Policy is enabled if set to true.
            ``enabled`` : bool
            /// Container name where blob inventory files are stored. Must be pre-created.
            ``destination`` : string
            /// The valid value is Inventory
            ``type`` : string
            /// The storage account blob inventory policy rules. The rule is applied when it is enabled.
            ``rules`` : BlobInventoryPolicyRule array
        }
        static member create(``enabled``, ``destination``, ``type``, ``rules``) =
            {
                ``enabled`` = ``enabled``
                ``destination`` = ``destination``
                ``type`` = ``type``
                ``rules`` = ``rules``
            }
    type BlobInventoryPolicyProperties =
        {
            /// Returns the last modified date and time of the blob inventory policy.
            ``lastModifiedTime`` : string option
            /// The storage account blob inventory policy rules.
            ``policy`` : BlobInventoryPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type InventoryPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The storage account blob inventory policy properties.
            ``properties`` : BlobInventoryPolicyProperties option
            /// Metadata pertaining to creation and last modification of the resource.
            ``systemData`` : systemData option
        }
        static member create(``name``, ?``id``, ?``properties``, ?``systemData``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
                ``systemData`` = ``systemData``
            }
namespace Microsoft.Storage.StorageAccounts.ManagementPolicies

module ``2018-03-01-preview`` =
    type ManagementPoliciesRules =
        {
            /// The Storage Account ManagementPolicies Rules, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : obj option
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
        }
        static member create(?``policy``, ?``lastModifiedTime``) =
            {
                ``policy`` = ``policy``
                ``lastModifiedTime`` = ``lastModifiedTime``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicies Rules, in JSON format. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``properties`` : ManagementPoliciesRules option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2018-11-01`` =
    type ManagementPolicyFilter =
        {
            /// An array of strings for prefixes to be match.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Only blockBlob is supported.
            ``blobTypes`` : string array
        }
        static member create(``blobTypes``, ?``prefixMatch``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
            }
    type DateAfterCreation =
        {
            /// Integer value indicating the age in days after creation
            ``daysAfterCreationGreaterThan`` : int
        }
        static member create(``daysAfterCreationGreaterThan``) =
            {
                ``daysAfterCreationGreaterThan`` = ``daysAfterCreationGreaterThan``
            }
    type ManagementPolicySnapShot =
        {
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``delete``) =
            {
                ``delete`` = ``delete``
            }
    type DateAfterModification =
        {
            /// Integer value indicating the age in days after last modification
            ``daysAfterModificationGreaterThan`` : int
        }
        static member create(``daysAfterModificationGreaterThan``) =
            {
                ``daysAfterModificationGreaterThan`` = ``daysAfterModificationGreaterThan``
            }
    type ManagementPolicyBaseBlob =
        {
            /// Object to define the number of days after last modification.
            ``tierToCool`` : DateAfterModification option
            /// Object to define the number of days after last modification.
            ``tierToArchive`` : DateAfterModification option
            /// Object to define the number of days after last modification.
            ``delete`` : DateAfterModification option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type ManagementPolicyAction =
        {
            /// Management policy action for base blob.
            ``baseBlob`` : ManagementPolicyBaseBlob option
            /// Management policy action for snapshot.
            ``snapshot`` : ManagementPolicySnapShot option
        }
        static member create(?``baseBlob``, ?``snapshot``) =
            {
                ``baseBlob`` = ``baseBlob``
                ``snapshot`` = ``snapshot``
            }
    type ManagementPolicyDefinition =
        {
            /// Actions are applied to the filtered blobs when the execution condition is met.
            ``actions`` : ManagementPolicyAction
            /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ManagementPolicyFilter option
        }
        static member create(``actions``, ?``filters``) =
            {
                ``actions`` = ``actions``
                ``filters`` = ``filters``
            }
    type ManagementPolicyRule =
        {
            /// Rule is enabled if set to true.
            ``enabled`` : bool option
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// The valid value is Lifecycle
            ``type`` : string
            /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
            ``definition`` : ManagementPolicyDefinition
        }
        static member create(``name``, ``type``, ``definition``, ?``enabled``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``type`` = ``type``
                ``definition`` = ``definition``
            }
    type ManagementPolicySchema =
        {
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``rules`` : ManagementPolicyRule array
        }
        static member create(``rules``) =
            {
                ``rules`` = ``rules``
            }
    type ManagementPolicyProperties =
        {
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : ManagementPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicy properties.
            ``properties`` : ManagementPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2019-04-01`` =
    type ManagementPolicyFilter =
        {
            /// An array of strings for prefixes to be match.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Only blockBlob is supported.
            ``blobTypes`` : string array
        }
        static member create(``blobTypes``, ?``prefixMatch``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
            }
    type DateAfterCreation =
        {
            /// Value indicating the age in days after creation
            ``daysAfterCreationGreaterThan`` : int
        }
        static member create(``daysAfterCreationGreaterThan``) =
            {
                ``daysAfterCreationGreaterThan`` = ``daysAfterCreationGreaterThan``
            }
    type ManagementPolicySnapShot =
        {
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``delete``) =
            {
                ``delete`` = ``delete``
            }
    type DateAfterModification =
        {
            /// Value indicating the age in days after last modification
            ``daysAfterModificationGreaterThan`` : int
        }
        static member create(``daysAfterModificationGreaterThan``) =
            {
                ``daysAfterModificationGreaterThan`` = ``daysAfterModificationGreaterThan``
            }
    type ManagementPolicyBaseBlob =
        {
            /// Object to define the number of days after last modification.
            ``tierToCool`` : DateAfterModification option
            /// Object to define the number of days after last modification.
            ``tierToArchive`` : DateAfterModification option
            /// Object to define the number of days after last modification.
            ``delete`` : DateAfterModification option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type ManagementPolicyAction =
        {
            /// Management policy action for base blob.
            ``baseBlob`` : ManagementPolicyBaseBlob option
            /// Management policy action for snapshot.
            ``snapshot`` : ManagementPolicySnapShot option
        }
        static member create(?``baseBlob``, ?``snapshot``) =
            {
                ``baseBlob`` = ``baseBlob``
                ``snapshot`` = ``snapshot``
            }
    type ManagementPolicyDefinition =
        {
            /// Actions are applied to the filtered blobs when the execution condition is met.
            ``actions`` : ManagementPolicyAction
            /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ManagementPolicyFilter option
        }
        static member create(``actions``, ?``filters``) =
            {
                ``actions`` = ``actions``
                ``filters`` = ``filters``
            }
    type ManagementPolicyRule =
        {
            /// Rule is enabled if set to true.
            ``enabled`` : bool option
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// The valid value is Lifecycle
            ``type`` : string
            /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
            ``definition`` : ManagementPolicyDefinition
        }
        static member create(``name``, ``type``, ``definition``, ?``enabled``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``type`` = ``type``
                ``definition`` = ``definition``
            }
    type ManagementPolicySchema =
        {
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``rules`` : ManagementPolicyRule array
        }
        static member create(``rules``) =
            {
                ``rules`` = ``rules``
            }
    type ManagementPolicyProperties =
        {
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : ManagementPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicy properties.
            ``properties`` : ManagementPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2019-06-01`` =
    type TagFilter =
        {
            /// This is the filter tag name, it can have 1 - 128 characters
            ``name`` : string
            /// This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported
            ``op`` : string
            /// This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters
            ``value`` : string
        }
        static member create(``name``, ``op``, ``value``) =
            {
                ``name`` = ``name``
                ``op`` = ``op``
                ``value`` = ``value``
            }
    type ManagementPolicyFilter =
        {
            /// An array of strings for prefixes to be match.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete actions are supported for appendBlob.
            ``blobTypes`` : string array
            /// An array of blob index tag based filters, there can be at most 10 tag filters
            ``blobIndexMatch`` : TagFilter array option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``blobIndexMatch``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``blobIndexMatch`` = ``blobIndexMatch``
            }
    type DateAfterCreation =
        {
            /// Value indicating the age in days after creation
            ``daysAfterCreationGreaterThan`` : int
        }
        static member create(``daysAfterCreationGreaterThan``) =
            {
                ``daysAfterCreationGreaterThan`` = ``daysAfterCreationGreaterThan``
            }
    type ManagementPolicyVersion =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type ManagementPolicySnapShot =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type DateAfterModification =
        {
            /// Value indicating the age in days after last modification
            ``daysAfterModificationGreaterThan`` : int option
            /// Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy
            ``daysAfterLastAccessTimeGreaterThan`` : int option
        }
        static member create(?``daysAfterModificationGreaterThan``, ?``daysAfterLastAccessTimeGreaterThan``) =
            {
                ``daysAfterModificationGreaterThan`` = ``daysAfterModificationGreaterThan``
                ``daysAfterLastAccessTimeGreaterThan`` = ``daysAfterLastAccessTimeGreaterThan``
            }
    type ManagementPolicyBaseBlob =
        {
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToCool`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToArchive`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``delete`` : DateAfterModification option
            /// This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
            ``enableAutoTierToHotFromCool`` : bool option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``, ?``enableAutoTierToHotFromCool``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
                ``enableAutoTierToHotFromCool`` = ``enableAutoTierToHotFromCool``
            }
    type ManagementPolicyAction =
        {
            /// Management policy action for base blob.
            ``baseBlob`` : ManagementPolicyBaseBlob option
            /// Management policy action for snapshot.
            ``snapshot`` : ManagementPolicySnapShot option
            /// Management policy action for blob version.
            ``version`` : ManagementPolicyVersion option
        }
        static member create(?``baseBlob``, ?``snapshot``, ?``version``) =
            {
                ``baseBlob`` = ``baseBlob``
                ``snapshot`` = ``snapshot``
                ``version`` = ``version``
            }
    type ManagementPolicyDefinition =
        {
            /// Actions are applied to the filtered blobs when the execution condition is met.
            ``actions`` : ManagementPolicyAction
            /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ManagementPolicyFilter option
        }
        static member create(``actions``, ?``filters``) =
            {
                ``actions`` = ``actions``
                ``filters`` = ``filters``
            }
    type ManagementPolicyRule =
        {
            /// Rule is enabled if set to true.
            ``enabled`` : bool option
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// The valid value is Lifecycle
            ``type`` : string
            /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
            ``definition`` : ManagementPolicyDefinition
        }
        static member create(``name``, ``type``, ``definition``, ?``enabled``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``type`` = ``type``
                ``definition`` = ``definition``
            }
    type ManagementPolicySchema =
        {
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``rules`` : ManagementPolicyRule array
        }
        static member create(``rules``) =
            {
                ``rules`` = ``rules``
            }
    type ManagementPolicyProperties =
        {
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : ManagementPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicy properties.
            ``properties`` : ManagementPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type TagFilter =
        {
            /// This is the filter tag name, it can have 1 - 128 characters
            ``name`` : string
            /// This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported
            ``op`` : string
            /// This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters
            ``value`` : string
        }
        static member create(``name``, ``op``, ``value``) =
            {
                ``name`` = ``name``
                ``op`` = ``op``
                ``value`` = ``value``
            }
    type ManagementPolicyFilter =
        {
            /// An array of strings for prefixes to be match.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete actions are supported for appendBlob.
            ``blobTypes`` : string array
            /// An array of blob index tag based filters, there can be at most 10 tag filters
            ``blobIndexMatch`` : TagFilter array option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``blobIndexMatch``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``blobIndexMatch`` = ``blobIndexMatch``
            }
    type DateAfterCreation =
        {
            /// Value indicating the age in days after creation
            ``daysAfterCreationGreaterThan`` : int
        }
        static member create(``daysAfterCreationGreaterThan``) =
            {
                ``daysAfterCreationGreaterThan`` = ``daysAfterCreationGreaterThan``
            }
    type ManagementPolicyVersion =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type ManagementPolicySnapShot =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type DateAfterModification =
        {
            /// Value indicating the age in days after last modification
            ``daysAfterModificationGreaterThan`` : int option
            /// Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy
            ``daysAfterLastAccessTimeGreaterThan`` : int option
        }
        static member create(?``daysAfterModificationGreaterThan``, ?``daysAfterLastAccessTimeGreaterThan``) =
            {
                ``daysAfterModificationGreaterThan`` = ``daysAfterModificationGreaterThan``
                ``daysAfterLastAccessTimeGreaterThan`` = ``daysAfterLastAccessTimeGreaterThan``
            }
    type ManagementPolicyBaseBlob =
        {
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToCool`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToArchive`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``delete`` : DateAfterModification option
            /// This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
            ``enableAutoTierToHotFromCool`` : bool option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``, ?``enableAutoTierToHotFromCool``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
                ``enableAutoTierToHotFromCool`` = ``enableAutoTierToHotFromCool``
            }
    type ManagementPolicyAction =
        {
            /// Management policy action for base blob.
            ``baseBlob`` : ManagementPolicyBaseBlob option
            /// Management policy action for snapshot.
            ``snapshot`` : ManagementPolicySnapShot option
            /// Management policy action for blob version.
            ``version`` : ManagementPolicyVersion option
        }
        static member create(?``baseBlob``, ?``snapshot``, ?``version``) =
            {
                ``baseBlob`` = ``baseBlob``
                ``snapshot`` = ``snapshot``
                ``version`` = ``version``
            }
    type ManagementPolicyDefinition =
        {
            /// Actions are applied to the filtered blobs when the execution condition is met.
            ``actions`` : ManagementPolicyAction
            /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ManagementPolicyFilter option
        }
        static member create(``actions``, ?``filters``) =
            {
                ``actions`` = ``actions``
                ``filters`` = ``filters``
            }
    type ManagementPolicyRule =
        {
            /// Rule is enabled if set to true.
            ``enabled`` : bool option
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// The valid value is Lifecycle
            ``type`` : string
            /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
            ``definition`` : ManagementPolicyDefinition
        }
        static member create(``name``, ``type``, ``definition``, ?``enabled``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``type`` = ``type``
                ``definition`` = ``definition``
            }
    type ManagementPolicySchema =
        {
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``rules`` : ManagementPolicyRule array
        }
        static member create(``rules``) =
            {
                ``rules`` = ``rules``
            }
    type ManagementPolicyProperties =
        {
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : ManagementPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicy properties.
            ``properties`` : ManagementPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type TagFilter =
        {
            /// This is the filter tag name, it can have 1 - 128 characters
            ``name`` : string
            /// This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported
            ``op`` : string
            /// This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters
            ``value`` : string
        }
        static member create(``name``, ``op``, ``value``) =
            {
                ``name`` = ``name``
                ``op`` = ``op``
                ``value`` = ``value``
            }
    type ManagementPolicyFilter =
        {
            /// An array of strings for prefixes to be match.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete actions are supported for appendBlob.
            ``blobTypes`` : string array
            /// An array of blob index tag based filters, there can be at most 10 tag filters
            ``blobIndexMatch`` : TagFilter array option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``blobIndexMatch``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``blobIndexMatch`` = ``blobIndexMatch``
            }
    type DateAfterCreation =
        {
            /// Value indicating the age in days after creation
            ``daysAfterCreationGreaterThan`` : int
        }
        static member create(``daysAfterCreationGreaterThan``) =
            {
                ``daysAfterCreationGreaterThan`` = ``daysAfterCreationGreaterThan``
            }
    type ManagementPolicyVersion =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type ManagementPolicySnapShot =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type DateAfterModification =
        {
            /// Value indicating the age in days after last modification
            ``daysAfterModificationGreaterThan`` : int option
            /// Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy
            ``daysAfterLastAccessTimeGreaterThan`` : int option
        }
        static member create(?``daysAfterModificationGreaterThan``, ?``daysAfterLastAccessTimeGreaterThan``) =
            {
                ``daysAfterModificationGreaterThan`` = ``daysAfterModificationGreaterThan``
                ``daysAfterLastAccessTimeGreaterThan`` = ``daysAfterLastAccessTimeGreaterThan``
            }
    type ManagementPolicyBaseBlob =
        {
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToCool`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToArchive`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``delete`` : DateAfterModification option
            /// This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
            ``enableAutoTierToHotFromCool`` : bool option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``, ?``enableAutoTierToHotFromCool``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
                ``enableAutoTierToHotFromCool`` = ``enableAutoTierToHotFromCool``
            }
    type ManagementPolicyAction =
        {
            /// Management policy action for base blob.
            ``baseBlob`` : ManagementPolicyBaseBlob option
            /// Management policy action for snapshot.
            ``snapshot`` : ManagementPolicySnapShot option
            /// Management policy action for blob version.
            ``version`` : ManagementPolicyVersion option
        }
        static member create(?``baseBlob``, ?``snapshot``, ?``version``) =
            {
                ``baseBlob`` = ``baseBlob``
                ``snapshot`` = ``snapshot``
                ``version`` = ``version``
            }
    type ManagementPolicyDefinition =
        {
            /// Actions are applied to the filtered blobs when the execution condition is met.
            ``actions`` : ManagementPolicyAction
            /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ManagementPolicyFilter option
        }
        static member create(``actions``, ?``filters``) =
            {
                ``actions`` = ``actions``
                ``filters`` = ``filters``
            }
    type ManagementPolicyRule =
        {
            /// Rule is enabled if set to true.
            ``enabled`` : bool option
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// The valid value is Lifecycle
            ``type`` : string
            /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
            ``definition`` : ManagementPolicyDefinition
        }
        static member create(``name``, ``type``, ``definition``, ?``enabled``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``type`` = ``type``
                ``definition`` = ``definition``
            }
    type ManagementPolicySchema =
        {
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``rules`` : ManagementPolicyRule array
        }
        static member create(``rules``) =
            {
                ``rules`` = ``rules``
            }
    type ManagementPolicyProperties =
        {
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : ManagementPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicy properties.
            ``properties`` : ManagementPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type TagFilter =
        {
            /// This is the filter tag name, it can have 1 - 128 characters
            ``name`` : string
            /// This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported
            ``op`` : string
            /// This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters
            ``value`` : string
        }
        static member create(``name``, ``op``, ``value``) =
            {
                ``name`` = ``name``
                ``op`` = ``op``
                ``value`` = ``value``
            }
    type ManagementPolicyFilter =
        {
            /// An array of strings for prefixes to be match.
            ``prefixMatch`` : string array option
            /// An array of predefined enum values. Currently blockBlob supports all tiering and delete actions. Only delete actions are supported for appendBlob.
            ``blobTypes`` : string array
            /// An array of blob index tag based filters, there can be at most 10 tag filters
            ``blobIndexMatch`` : TagFilter array option
        }
        static member create(``blobTypes``, ?``prefixMatch``, ?``blobIndexMatch``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``blobTypes`` = ``blobTypes``
                ``blobIndexMatch`` = ``blobIndexMatch``
            }
    type DateAfterCreation =
        {
            /// Value indicating the age in days after creation
            ``daysAfterCreationGreaterThan`` : int
        }
        static member create(``daysAfterCreationGreaterThan``) =
            {
                ``daysAfterCreationGreaterThan`` = ``daysAfterCreationGreaterThan``
            }
    type ManagementPolicyVersion =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type ManagementPolicySnapShot =
        {
            /// Object to define the number of days after creation.
            ``tierToCool`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``tierToArchive`` : DateAfterCreation option
            /// Object to define the number of days after creation.
            ``delete`` : DateAfterCreation option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
            }
    type DateAfterModification =
        {
            /// Value indicating the age in days after last modification
            ``daysAfterModificationGreaterThan`` : int option
            /// Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy
            ``daysAfterLastAccessTimeGreaterThan`` : int option
        }
        static member create(?``daysAfterModificationGreaterThan``, ?``daysAfterLastAccessTimeGreaterThan``) =
            {
                ``daysAfterModificationGreaterThan`` = ``daysAfterModificationGreaterThan``
                ``daysAfterLastAccessTimeGreaterThan`` = ``daysAfterLastAccessTimeGreaterThan``
            }
    type ManagementPolicyBaseBlob =
        {
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToCool`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``tierToArchive`` : DateAfterModification option
            /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
            ``delete`` : DateAfterModification option
            /// This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
            ``enableAutoTierToHotFromCool`` : bool option
        }
        static member create(?``tierToCool``, ?``tierToArchive``, ?``delete``, ?``enableAutoTierToHotFromCool``) =
            {
                ``tierToCool`` = ``tierToCool``
                ``tierToArchive`` = ``tierToArchive``
                ``delete`` = ``delete``
                ``enableAutoTierToHotFromCool`` = ``enableAutoTierToHotFromCool``
            }
    type ManagementPolicyAction =
        {
            /// Management policy action for base blob.
            ``baseBlob`` : ManagementPolicyBaseBlob option
            /// Management policy action for snapshot.
            ``snapshot`` : ManagementPolicySnapShot option
            /// Management policy action for blob version.
            ``version`` : ManagementPolicyVersion option
        }
        static member create(?``baseBlob``, ?``snapshot``, ?``version``) =
            {
                ``baseBlob`` = ``baseBlob``
                ``snapshot`` = ``snapshot``
                ``version`` = ``version``
            }
    type ManagementPolicyDefinition =
        {
            /// Actions are applied to the filtered blobs when the execution condition is met.
            ``actions`` : ManagementPolicyAction
            /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ManagementPolicyFilter option
        }
        static member create(``actions``, ?``filters``) =
            {
                ``actions`` = ``actions``
                ``filters`` = ``filters``
            }
    type ManagementPolicyRule =
        {
            /// Rule is enabled if set to true.
            ``enabled`` : bool option
            /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
            ``name`` : string
            /// The valid value is Lifecycle
            ``type`` : string
            /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
            ``definition`` : ManagementPolicyDefinition
        }
        static member create(``name``, ``type``, ``definition``, ?``enabled``) =
            {
                ``enabled`` = ``enabled``
                ``name`` = ``name``
                ``type`` = ``type``
                ``definition`` = ``definition``
            }
    type ManagementPolicySchema =
        {
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``rules`` : ManagementPolicyRule array
        }
        static member create(``rules``) =
            {
                ``rules`` = ``rules``
            }
    type ManagementPolicyProperties =
        {
            /// Returns the date and time the ManagementPolicies was last modified.
            ``lastModifiedTime`` : string option
            /// The Storage Account ManagementPolicies Rules. See more details in: https://docs.microsoft.com/en-us/azure/storage/common/storage-lifecycle-managment-concepts.
            ``policy`` : ManagementPolicySchema
        }
        static member create(``policy``, ?``lastModifiedTime``) =
            {
                ``lastModifiedTime`` = ``lastModifiedTime``
                ``policy`` = ``policy``
            }
    type ManagementPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ManagementPolicy properties.
            ``properties`` : ManagementPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.ObjectReplicationPolicies

module ``2019-06-01`` =
    type ObjectReplicationPolicyFilter =
        {
            /// Optional. Filters the results to replicate only blobs whose names begin with the specified prefix.
            ``prefixMatch`` : string array option
            /// Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z
            ``minCreationTime`` : string option
        }
        static member create(?``prefixMatch``, ?``minCreationTime``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``minCreationTime`` = ``minCreationTime``
            }
    type ObjectReplicationPolicyRule =
        {
            /// Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account.
            ``ruleId`` : string option
            /// Required. Source container name.
            ``sourceContainer`` : string
            /// Required. Destination container name.
            ``destinationContainer`` : string
            /// Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ObjectReplicationPolicyFilter option
        }
        static member create(``sourceContainer``, ``destinationContainer``, ?``ruleId``, ?``filters``) =
            {
                ``ruleId`` = ``ruleId``
                ``sourceContainer`` = ``sourceContainer``
                ``destinationContainer`` = ``destinationContainer``
                ``filters`` = ``filters``
            }
    type ObjectReplicationPolicyProperties =
        {
            /// A unique id for object replication policy.
            ``policyId`` : string option
            /// Indicates when the policy is enabled on the source account.
            ``enabledTime`` : string option
            /// Required. Source account name.
            ``sourceAccount`` : string
            /// Required. Destination account name.
            ``destinationAccount`` : string
            /// The storage account object replication rules.
            ``rules`` : ObjectReplicationPolicyRule array option
        }
        static member create(``sourceAccount``, ``destinationAccount``, ?``policyId``, ?``enabledTime``, ?``rules``) =
            {
                ``policyId`` = ``policyId``
                ``enabledTime`` = ``enabledTime``
                ``sourceAccount`` = ``sourceAccount``
                ``destinationAccount`` = ``destinationAccount``
                ``rules`` = ``rules``
            }
    type ObjectReplicationPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ObjectReplicationPolicy properties.
            ``properties`` : ObjectReplicationPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type ObjectReplicationPolicyFilter =
        {
            /// Optional. Filters the results to replicate only blobs whose names begin with the specified prefix.
            ``prefixMatch`` : string array option
            /// Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z
            ``minCreationTime`` : string option
        }
        static member create(?``prefixMatch``, ?``minCreationTime``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``minCreationTime`` = ``minCreationTime``
            }
    type ObjectReplicationPolicyRule =
        {
            /// Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account.
            ``ruleId`` : string option
            /// Required. Source container name.
            ``sourceContainer`` : string
            /// Required. Destination container name.
            ``destinationContainer`` : string
            /// Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ObjectReplicationPolicyFilter option
        }
        static member create(``sourceContainer``, ``destinationContainer``, ?``ruleId``, ?``filters``) =
            {
                ``ruleId`` = ``ruleId``
                ``sourceContainer`` = ``sourceContainer``
                ``destinationContainer`` = ``destinationContainer``
                ``filters`` = ``filters``
            }
    type ObjectReplicationPolicyProperties =
        {
            /// A unique id for object replication policy.
            ``policyId`` : string option
            /// Indicates when the policy is enabled on the source account.
            ``enabledTime`` : string option
            /// Required. Source account name.
            ``sourceAccount`` : string
            /// Required. Destination account name.
            ``destinationAccount`` : string
            /// The storage account object replication rules.
            ``rules`` : ObjectReplicationPolicyRule array option
        }
        static member create(``sourceAccount``, ``destinationAccount``, ?``policyId``, ?``enabledTime``, ?``rules``) =
            {
                ``policyId`` = ``policyId``
                ``enabledTime`` = ``enabledTime``
                ``sourceAccount`` = ``sourceAccount``
                ``destinationAccount`` = ``destinationAccount``
                ``rules`` = ``rules``
            }
    type ObjectReplicationPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ObjectReplicationPolicy properties.
            ``properties`` : ObjectReplicationPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type ObjectReplicationPolicyFilter =
        {
            /// Optional. Filters the results to replicate only blobs whose names begin with the specified prefix.
            ``prefixMatch`` : string array option
            /// Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z
            ``minCreationTime`` : string option
        }
        static member create(?``prefixMatch``, ?``minCreationTime``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``minCreationTime`` = ``minCreationTime``
            }
    type ObjectReplicationPolicyRule =
        {
            /// Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account.
            ``ruleId`` : string option
            /// Required. Source container name.
            ``sourceContainer`` : string
            /// Required. Destination container name.
            ``destinationContainer`` : string
            /// Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ObjectReplicationPolicyFilter option
        }
        static member create(``sourceContainer``, ``destinationContainer``, ?``ruleId``, ?``filters``) =
            {
                ``ruleId`` = ``ruleId``
                ``sourceContainer`` = ``sourceContainer``
                ``destinationContainer`` = ``destinationContainer``
                ``filters`` = ``filters``
            }
    type ObjectReplicationPolicyProperties =
        {
            /// A unique id for object replication policy.
            ``policyId`` : string option
            /// Indicates when the policy is enabled on the source account.
            ``enabledTime`` : string option
            /// Required. Source account name.
            ``sourceAccount`` : string
            /// Required. Destination account name.
            ``destinationAccount`` : string
            /// The storage account object replication rules.
            ``rules`` : ObjectReplicationPolicyRule array option
        }
        static member create(``sourceAccount``, ``destinationAccount``, ?``policyId``, ?``enabledTime``, ?``rules``) =
            {
                ``policyId`` = ``policyId``
                ``enabledTime`` = ``enabledTime``
                ``sourceAccount`` = ``sourceAccount``
                ``destinationAccount`` = ``destinationAccount``
                ``rules`` = ``rules``
            }
    type ObjectReplicationPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ObjectReplicationPolicy properties.
            ``properties`` : ObjectReplicationPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type ObjectReplicationPolicyFilter =
        {
            /// Optional. Filters the results to replicate only blobs whose names begin with the specified prefix.
            ``prefixMatch`` : string array option
            /// Blobs created after the time will be replicated to the destination. It must be in datetime format 'yyyy-MM-ddTHH:mm:ssZ'. Example: 2020-02-19T16:05:00Z
            ``minCreationTime`` : string option
        }
        static member create(?``prefixMatch``, ?``minCreationTime``) =
            {
                ``prefixMatch`` = ``prefixMatch``
                ``minCreationTime`` = ``minCreationTime``
            }
    type ObjectReplicationPolicyRule =
        {
            /// Rule Id is auto-generated for each new rule on destination account. It is required for put policy on source account.
            ``ruleId`` : string option
            /// Required. Source container name.
            ``sourceContainer`` : string
            /// Required. Destination container name.
            ``destinationContainer`` : string
            /// Filters limit replication to a subset of blobs within the storage account. A logical OR is performed on values in the filter. If multiple filters are defined, a logical AND is performed on all filters.
            ``filters`` : ObjectReplicationPolicyFilter option
        }
        static member create(``sourceContainer``, ``destinationContainer``, ?``ruleId``, ?``filters``) =
            {
                ``ruleId`` = ``ruleId``
                ``sourceContainer`` = ``sourceContainer``
                ``destinationContainer`` = ``destinationContainer``
                ``filters`` = ``filters``
            }
    type ObjectReplicationPolicyProperties =
        {
            /// A unique id for object replication policy.
            ``policyId`` : string option
            /// Indicates when the policy is enabled on the source account.
            ``enabledTime`` : string option
            /// Required. Source account name.
            ``sourceAccount`` : string
            /// Required. Destination account name.
            ``destinationAccount`` : string
            /// The storage account object replication rules.
            ``rules`` : ObjectReplicationPolicyRule array option
        }
        static member create(``sourceAccount``, ``destinationAccount``, ?``policyId``, ?``enabledTime``, ?``rules``) =
            {
                ``policyId`` = ``policyId``
                ``enabledTime`` = ``enabledTime``
                ``sourceAccount`` = ``sourceAccount``
                ``destinationAccount`` = ``destinationAccount``
                ``rules`` = ``rules``
            }
    type ObjectReplicationPolicy =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The Storage Account ObjectReplicationPolicy properties.
            ``properties`` : ObjectReplicationPolicyProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.PrivateEndpointConnections

module ``2019-06-01`` =
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type PrivateLinkServiceConnectionState =
        {
            /// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
            ``status`` : obj // Status option
            /// The reason for approval/rejection of the connection.
            ``description`` : string option
            /// A message indicating if changes on the service provider require any updates on the consumer.
            ``actionRequired`` : string option
        }
        static member create(?``status``, ?``description``, ?``actionRequired``) =
            {
                ``status`` = ``status``
                ``description`` = ``description``
                ``actionRequired`` = ``actionRequired``
            }
    type PrivateEndpoint =
        {
            /// The ARM identifier for Private Endpoint
            ``id`` : string option
        }
        static member create(?``id``) =
            {
                ``id`` = ``id``
            }
    type PrivateEndpointConnectionProperties =
        {
            /// The Private Endpoint resource.
            ``privateEndpoint`` : PrivateEndpoint option
            /// A collection of information about the state of the connection between service consumer and provider.
            ``privateLinkServiceConnectionState`` : PrivateLinkServiceConnectionState option
            /// The provisioning state of the private endpoint connection resource.
            ``provisioningState`` : obj // ProvisioningState option
        }
        static member create(?``privateEndpoint``, ?``privateLinkServiceConnectionState``, ?``provisioningState``) =
            {
                ``privateEndpoint`` = ``privateEndpoint``
                ``privateLinkServiceConnectionState`` = ``privateLinkServiceConnectionState``
                ``provisioningState`` = ``provisioningState``
            }
    type PrivateEndpointConnection =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// Properties of the PrivateEndpointConnectProperties.
            ``properties`` : PrivateEndpointConnectionProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.QueueServices

module ``2019-06-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type QueueService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Queue service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type QueueService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Queue service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type QueueService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Queue service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type QueueService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Queue service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.QueueServices.Queues

module ``2019-06-01`` =
    type QueueProperties =
        {
            /// A name-value pair that represents queue metadata.
            ``metadata`` : Map<string, string> option
            /// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
            ``approximateMessageCount`` : int option
        }
        static member create(?``metadata``, ?``approximateMessageCount``) =
            {
                ``metadata`` = ``metadata``
                ``approximateMessageCount`` = ``approximateMessageCount``
            }
    type Queue =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : QueueProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type QueueProperties =
        {
            /// A name-value pair that represents queue metadata.
            ``metadata`` : Map<string, string> option
            /// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
            ``approximateMessageCount`` : int option
        }
        static member create(?``metadata``, ?``approximateMessageCount``) =
            {
                ``metadata`` = ``metadata``
                ``approximateMessageCount`` = ``approximateMessageCount``
            }
    type Queue =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : QueueProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type QueueProperties =
        {
            /// A name-value pair that represents queue metadata.
            ``metadata`` : Map<string, string> option
            /// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
            ``approximateMessageCount`` : int option
        }
        static member create(?``metadata``, ?``approximateMessageCount``) =
            {
                ``metadata`` = ``metadata``
                ``approximateMessageCount`` = ``approximateMessageCount``
            }
    type Queue =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : QueueProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type QueueProperties =
        {
            /// A name-value pair that represents queue metadata.
            ``metadata`` : Map<string, string> option
            /// Integer indicating an approximate number of messages in the queue. This number is not lower than the actual number of messages in the queue, but could be higher.
            ``approximateMessageCount`` : int option
        }
        static member create(?``metadata``, ?``approximateMessageCount``) =
            {
                ``metadata`` = ``metadata``
                ``approximateMessageCount`` = ``approximateMessageCount``
            }
    type Queue =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : QueueProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.TableServices

module ``2019-06-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type TableService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Table service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type TableService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Table service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type TableService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Table service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type CorsRule =
        {
            /// Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains
            ``allowedOrigins`` : string array
            /// Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin.
            ``allowedMethods`` : obj // AllowedMethods array
            /// Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response.
            ``maxAgeInSeconds`` : int
            /// Required if CorsRule element is present. A list of response headers to expose to CORS clients.
            ``exposedHeaders`` : string array
            /// Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request.
            ``allowedHeaders`` : string array
        }
        static member create(``allowedOrigins``, ``allowedMethods``, ``maxAgeInSeconds``, ``exposedHeaders``, ``allowedHeaders``) =
            {
                ``allowedOrigins`` = ``allowedOrigins``
                ``allowedMethods`` = ``allowedMethods``
                ``maxAgeInSeconds`` = ``maxAgeInSeconds``
                ``exposedHeaders`` = ``exposedHeaders``
                ``allowedHeaders`` = ``allowedHeaders``
            }
    type CorsRules =
        {
            /// The List of CORS rules. You can include up to five CorsRule elements in the request.
            ``corsRules`` : CorsRule array option
        }
        static member create(?``corsRules``) =
            {
                ``corsRules`` = ``corsRules``
            }
    type Properties =
        {
            /// Sets the CORS rules. You can include up to five CorsRule elements in the request.
            ``cors`` : CorsRules option
        }
        static member create(?``cors``) =
            {
                ``cors`` = ``cors``
            }
    type TableService =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            /// The properties of a storage account’s Table service.
            ``properties`` : Properties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
namespace Microsoft.Storage.StorageAccounts.TableServices.Tables

module ``2019-06-01`` =
    type TableProperties =
        {
            /// Table name under the specified account
            ``tableName`` : string option
        }
        static member create(?``tableName``) =
            {
                ``tableName`` = ``tableName``
            }
    type Table =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : TableProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2020-08-01-preview`` =
    type TableProperties =
        {
            /// Table name under the specified account
            ``tableName`` : string option
        }
        static member create(?``tableName``) =
            {
                ``tableName`` = ``tableName``
            }
    type Table =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : TableProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-01-01`` =
    type TableProperties =
        {
            /// Table name under the specified account
            ``tableName`` : string option
        }
        static member create(?``tableName``) =
            {
                ``tableName`` = ``tableName``
            }
    type Table =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : TableProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }
module ``2021-02-01`` =
    type TableProperties =
        {
            /// Table name under the specified account
            ``tableName`` : string option
        }
        static member create(?``tableName``) =
            {
                ``tableName`` = ``tableName``
            }
    type Table =
        {
            /// The resource id
            ``id`` : string option
            /// The resource name
            ``name`` : string
            ``properties`` : TableProperties option
        }
        static member create(``name``, ?``id``, ?``properties``) =
            {
                ``id`` = ``id``
                ``name`` = ``name``
                ``properties`` = ``properties``
            }