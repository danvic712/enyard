import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react-swc'
import mkcert from "vite-plugin-mkcert";
import path from 'path'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [react(), mkcert()],
  server: {
    port: 3001,
    https: true,
    strictPort : true,
    proxy: {
      '/api' : {
        target: 'https://localhost:7178',
        changeOrigin: true,
        secure: false,
        rewrite: (path) => path.replace(/^\/api/, '/api')
      }
    }
  },
  resolve: {
    alias: {
      "@": path.resolve(__dirname, "./src"),
    },
  },
})
