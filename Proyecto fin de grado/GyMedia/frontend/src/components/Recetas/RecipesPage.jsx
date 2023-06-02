import React from 'react'
import { RecipeContext, RecipeProvider } from '../../Context/RecipeContext'
import Recetas from './Recetas'

export default function RecipesPage() {
  return (
    <RecipeProvider>
    <Recetas />
    </RecipeProvider>
  )
}
