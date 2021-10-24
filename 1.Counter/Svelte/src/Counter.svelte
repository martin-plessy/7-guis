<script lang="ts">
	let counterValue = 0

	function onClick() {
		++counterValue
	}
</script>

<input type="number" readonly bind:value={counterValue} data-testid="counterNumber">
<input type="button" value="Count" on:click={onClick} data-testid="counterButton">
