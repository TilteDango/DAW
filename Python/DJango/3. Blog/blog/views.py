from django.shortcuts import render
from .models import Post
from django.views.generic import ListView, DetailView
# Create your views here.

class BlogListView(ListView):
    model = Post
    template_name = 'home.html'


class BlogDetailView(DetailView):
    model = Post
    template_name = 'post_detail.html'


class BlogDetailView(DetailView):
    model = Post
    template_name = 'post_detail.html'
    context_object_name = 'anything_you_want'