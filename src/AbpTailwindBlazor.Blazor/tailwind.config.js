module.exports = {
  content: [
    '!**/{bin,obj,node_modules}/**',
    '**/*.{razor,html}',
  ],
  theme: {
    extend: {},
  },
  corePlugins: {
    preflight: false,
  },
  prefix: 'tw-',
  plugins: [],
}
