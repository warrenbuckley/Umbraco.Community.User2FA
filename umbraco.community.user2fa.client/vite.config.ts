import { defineConfig } from 'vite';

export default defineConfig({
  build: {
    lib: {
      entry: "src/index.ts", // Entrypoint file (registers other manifests)
      formats: ["es"],
      fileName: 'umbraco.community.user2fa',
    },
    outDir: '../Umbraco.Community.User2FA/wwwroot', // your web component will be saved to the RCL project location and the RCL sets the path as App_Plugins/Umbraco.Community.User2FA
    emptyOutDir: true,
    sourcemap: true,
    rollupOptions: {
      external: [/^@umbraco/],
    },
  },
});
