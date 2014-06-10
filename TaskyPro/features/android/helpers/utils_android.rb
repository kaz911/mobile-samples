module TaskyPro
  module AndroidHelpers
    def enter_text(uiquery, text)
      query(uiquery, {:setText => text})
    end

    def clear_text(uiquery)
      enter_text(uiquery, "")
    end
  end
end

World(TaskyPro::AndroidHelpers)