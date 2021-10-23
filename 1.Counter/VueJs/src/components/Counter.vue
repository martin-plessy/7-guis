<template>
  <input type="number" readonly v-bind:valueAsNumber="counterValue" data-test-id="counterNumber"/>
  <input type="button" autofocus value="Count" v-on:click="++counterValue" data-test-id="counterButton"/>
</template>

<script lang="ts">
export default {
  data: () => ({
    counterValue: 0
  })
}
</script>
