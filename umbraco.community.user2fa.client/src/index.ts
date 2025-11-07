import { UmbEntryPointOnInit } from '@umbraco-cms/backoffice/extension-api';
export const onInit: UmbEntryPointOnInit = (_host, _extensionRegistry) => {
    // Empty stub if we want to register something in the future
    // For now we register the only manifest directly in the umbraco-package.json as it requires no backing JS

    // Perhaps consider some custom UI webcomponent to replace textbox for code entry
    // To be individual input fields seen in other sites/UIs for 2FA
};