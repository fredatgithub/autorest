import { TypespecParameter } from "../interfaces";
import { generateDecorators } from "../utils/decorators";
import { generateDocs } from "../utils/docs";
import { transformDefaultValue } from "../utils/values";

export function generateParameter(parameter: TypespecParameter): string {
  const definitions: string[] = [];
  const doc = generateDocs(parameter);
  definitions.push(doc);

  const decorators = generateDecorators(parameter.decorators);
  decorators && definitions.push(decorators);
  let defaultValue = "";
  if (parameter.defaultValue) {
    defaultValue = ` = ${transformDefaultValue(parameter.type, parameter.defaultValue)}`;
  }
  definitions.push(`"${parameter.name}"${parameter.isOptional ? "?" : ""}: ${parameter.type}${defaultValue}`);

  return definitions.join("\n");
}