import Counter from './Counter.svelte'
import { render, fireEvent } from '@testing-library/svelte'

describe(Counter, () => {
	it("starts with a value of zero", () => {
		const counter = render(Counter)
		const counterNumber = counter.getByTestId("counterNumber") as HTMLInputElement

		expect(counterNumber.valueAsNumber).toBe(0)
	})

	it("increments the value on click", async () => {
		const counter = render(Counter)
		const counterNumber = counter.getByTestId("counterNumber") as HTMLInputElement
		const counterButton = counter.getByTestId("counterButton") as HTMLInputElement

		await fireEvent.click(counterButton)
		await fireEvent.click(counterButton)
		await fireEvent.click(counterButton)

		expect(counterNumber.valueAsNumber).toBe(3)
	})
})
