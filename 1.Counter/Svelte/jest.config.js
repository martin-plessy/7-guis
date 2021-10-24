module.exports = {
  transform: {
    '^.+\\.svelte$': 'svelte-jester',
    '^.+\\.ts$': 'babel-jest',
  },
  moduleFileExtensions: ['js', 'ts', 'svelte'],
  testEnvironment: "jsdom"
}
