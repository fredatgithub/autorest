/**
 * Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package storage.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The List Usages operation response.
 */
public class UsageListResult {
    /**
     * Gets or sets the list Storage Resource Usages.
     */
    @JsonProperty(value = "value")
    private List<Usage> value;

    /**
     * Get the value value.
     *
     * @return the value value
     */
    public List<Usage> value() {
        return this.value;
    }

    /**
     * Set the value value.
     *
     * @param value the value value to set
     * @return the UsageListResult object itself.
     */
    public UsageListResult withValue(List<Usage> value) {
        this.value = value;
        return this;
    }

}
