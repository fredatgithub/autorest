import "@azure-tools/typespec-azure-core";
import "@azure-tools/typespec-azure-resource-manager";
import "@typespec/openapi";
import "@typespec/rest";
import "./models.tsp";
import "./ApiManagementServiceResource.tsp";

using TypeSpec.Rest;
using Azure.ResourceManager;
using Azure.ResourceManager.Foundations;
using TypeSpec.Http;
using TypeSpec.OpenAPI;

namespace Azure.ResourceManager.ApiManagement;
/**
 * Gateway details.
 */
@parentResource(ApiManagementServiceResource)
model GatewayContract is ProxyResource<GatewayContractProperties> {
  /**
   * Gateway entity identifier. Must be unique in the current API Management service instance. Must not have value 'managed'
   */
  @maxLength(80)
  @minLength(1)
  @path
  @key("gatewayId")
  @segment("gateways")
  name: string;
}

@armResourceOperations
interface GatewayContracts {
  /**
   * Gets the details of the Gateway specified by its identifier.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_Get")
  get is ArmResourceRead<GatewayContract>;

  /**
   * Gets the entity state (Etag) version of the Gateway specified by its identifier.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @head
  @operationId("Gateway_GetEntityTag")
  getEntityTag(
    ...ResourceInstanceParameters<
      GatewayContract,
      BaseParameters<GatewayContract>
    >,
  ): OkResponse | ErrorResponse;

  /**
   * Creates or updates a Gateway to be used in Api Management instance.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_CreateOrUpdate")
  createOrUpdate is ArmResourceCreateOrReplaceSync<
    GatewayContract,
    {
      ...BaseParameters<GatewayContract>;

      /**
       * ETag of the Entity. Not required when creating an entity, but required when updating an entity.
       */
      @header
      `If-Match`?: string;
    }
  >;

  /**
   * Updates the details of the gateway specified by its identifier.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @parameterVisibility("read")
  @operationId("Gateway_Update")
  update is ArmCustomPatchSync<
    GatewayContract,
    GatewayContract,
    {
      ...BaseParameters<GatewayContract>;

      /**
       * ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update.
       */
      @header
      `If-Match`: string;
    }
  >;

  /**
   * Deletes specific Gateway.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_Delete")
  delete is ArmResourceDeleteSync<
    GatewayContract,
    {
      ...BaseParameters<GatewayContract>;

      /**
       * ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update.
       */
      @header
      `If-Match`: string;
    }
  >;

  /**
   * Lists a collection of gateways registered with service instance.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_ListByService")
  listByService is ArmResourceListByParent<
    GatewayContract,
    {
      ...BaseParameters<GatewayContract>;

      /**
       * |     Field     |     Usage     |     Supported operators     |     Supported functions     |</br>|-------------|-------------|-------------|-------------|</br>| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |</br>| region | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |</br>| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |</br>
       */
      @query("$filter")
      $filter?: string;

      /**
       * Number of records to return.
       */
      @minValue(1)
      @query("$top")
      $top?: int32;

      /**
       * Number of records to skip.
       */
      @query("$skip")
      $skip?: int32;
    }
  >;

  /**
   * Retrieves gateway keys.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_ListKeys")
  listKeys is ArmResourceActionSync<GatewayContract, void, GatewayKeysContract>;

  /**
   * Regenerates specified gateway key invalidating any tokens created with it.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_RegenerateKey")
  regenerateKey is ArmResourceActionNoContentSync<
    GatewayContract,
    GatewayKeyRegenerationRequestContract
  >;

  /**
   * Gets the Shared Access Authorization Token for the gateway.
   */
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("Gateway_GenerateToken")
  generateToken is ArmResourceActionSync<
    GatewayContract,
    GatewayTokenRequestContract,
    GatewayTokenContract
  >;

  /**
   * Lists a collection of the APIs associated with a gateway.
   */
  // FIXME: GatewayApi_ListByService could not be converted to a resource operation
  #suppress "@azure-tools/typespec-azure-core/no-operation-id" "For backward compatibility"
  @operationId("GatewayApi_ListByService")
  @route("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/apis")
  @get
  listByService is Azure.Core.Foundations.Operation<
    {
      /**
       * The name of the resource group.
       */
      @path
      resourceGroupName: string;

      /**
       * The name of the API Management service.
       */
      @maxLength(50)
      @minLength(1)
      @pattern("^[a-zA-Z](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?$")
      @path
      serviceName: string;

      /**
       * Gateway entity identifier. Must be unique in the current API Management service instance. Must not have value 'managed'
       */
      @maxLength(80)
      @minLength(1)
      @path
      gatewayId: string;

      /**
       * |     Field     |     Usage     |     Supported operators     |     Supported functions     |</br>|-------------|-------------|-------------|-------------|</br>| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |</br>
       */
      @query("$filter")
      $filter?: string;

      /**
       * Number of records to return.
       */
      @minValue(1)
      @query("$top")
      $top?: int32;

      /**
       * Number of records to skip.
       */
      @query("$skip")
      $skip?: int32;

      /**
       * Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
       */
      @path
      subscriptionId: string;
    },
    ApiManagementGatewayApiListResult
  >;
}

@@projectedName(GatewayContracts.createOrUpdate::parameters.resource,
  "json",
  "parameters"
);
@@extension(GatewayContracts.createOrUpdate::parameters.resource,
  "x-ms-client-name",
  "parameters"
);
@@doc(GatewayContracts.createOrUpdate::parameters.resource, "");
@@projectedName(GatewayContracts.update::parameters.properties,
  "json",
  "parameters"
);
@@extension(GatewayContracts.update::parameters.properties,
  "x-ms-client-name",
  "parameters"
);
@@doc(GatewayContracts.update::parameters.properties, "");
@@projectedName(GatewayContracts.regenerateKey::parameters.body,
  "json",
  "parameters"
);
@@extension(GatewayContracts.regenerateKey::parameters.body,
  "x-ms-client-name",
  "parameters"
);
@@doc(GatewayContracts.regenerateKey::parameters.body, "");
@@projectedName(GatewayContracts.generateToken::parameters.body,
  "json",
  "parameters"
);
@@extension(GatewayContracts.generateToken::parameters.body,
  "x-ms-client-name",
  "parameters"
);
@@doc(GatewayContracts.generateToken::parameters.body, "");