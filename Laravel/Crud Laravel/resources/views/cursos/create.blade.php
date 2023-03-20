@extends('layout.plantilla')

@section('title', 'Create')

@section('content')
    <h1>En esta página podras crear un curso</h1>

    <form action="{{ route('cursos.store') }}" method="POST">
        @csrf

        <label for="name">
            Nombre
        </label>
        <input type="text" name="name" value="{{old('name')}}">
        @error('name')
            <small>*{{ $message }}</small>
        @enderror

        <label for="description">
            Descripción
        </label>
        <textarea name="description" cols="30" rows="10">{{old('description')}}</textarea>

        @error('description')
            <small>*{{ $message }}</small>
        @enderror

        <label for="category">
            Categoria
        </label>
        <input type="text" name="category" value="{{old('category')}}">
        @error('category')
            <small>*{{ $message }}</small>
        @enderror
        <input type="submit">
    </form>
@endsection
