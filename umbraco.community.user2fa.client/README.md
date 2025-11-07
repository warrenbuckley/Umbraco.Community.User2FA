# Notes
The client project has one responsiblity current to register one thing.

This is done purely via the umbraco-package.json manifest to register a `mfaLoginProvider`, as we currently have no other UI, WebComponents or similar to extend then the TypeScript, Vite build setup is currently overkill, but an entrypoint is setup in case we do decide we want to extend the backoffice with any other UI components.