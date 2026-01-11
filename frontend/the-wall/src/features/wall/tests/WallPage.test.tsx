import { render, screen } from "@testing-library/react";
import userEvent from "@testing-library/user-event";
import { describe, it, expect, vi } from "vitest";
import WallPage from "../WallPage";

describe("WallPage", () => {
    it("display loading state while phrases are being loaded", async () => {
        const user = userEvent.setup();

        // Given the user opens the wall page
        render(<WallPage />);

        // When phrases are being fetched
        vi.spyOn(phraseService, "fetchPhrases").mockImplementation(
            () => new Promise(() => { })
        );

        // Then a loading indicator is displayed
        expect(screen.getByLabelText(/loading/i)).toBeInTheDocument();
    });
});

describe("WallPage", () => {
    it("allows publishing a phrase from the wall", async () => {
        const user = userEvent.setup();

        // Given the wall page is open
        render(<WallPage />);

        // And the publish phrase form is displayed
        const textArea = screen.getByRole("textbox");
        expect(textArea).toBeInTheDocument();

        const fontSelect = screen.getByLabelText(/font/i);
        expect(fontSelect).toBeInTheDocument();

        const fontSizeSelect = screen.getByLabelText(/size/i);
        expect(fontSizeSelect).toBeInTheDocument();

        const colorInput = screen.getByLabelText(/color/i);
        expect(colorInput).toBeInTheDocument();

        // When the user submits a phrase with text and style (font, fontsize and color)
        await user.type(textArea, "Hello world!");
        await user.selectOptions(fontSelect, "Arial");
        await user.selectOptions(fontSizeSelect, "10");
        await user.type(colorInput, "#ff0000");

        const publishButton = screen.getByRole("button", {
            name: /publish/i
        });

        await user.click(publishButton);

        // Then the wall is refreshed
        // And the new phrase is displayed prominently
        expect(screen.getByText("Hello world!")).toBeInTheDocument();
    });
});